using AppGroupe2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.View;

namespace AppGroupe2.View
{

    public partial class frmRendezVous : Form
    {

       
        public frmRendezVous()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmRendezVous_Load);
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnImprimer.Location = new System.Drawing.Point(150, 450); // Ajuster la position
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(100, 30);
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            this.Controls.Add(this.btnImprimer);
        }
        BdRvMedicalContexe db = new BdRvMedicalContexe();

        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            // Charger les patients, médecins et soins (comme avant)
            cbPatient.DataSource = db.Patients.ToList();
            cbPatient.DisplayMember = "NomPrenom";
            cbPatient.ValueMember = "IDU";

            cbMedecin.DataSource = db.Medecins.ToList();
            cbMedecin.DisplayMember = "NomPrenom";
            cbMedecin.ValueMember = "IDU";

            cbSoin.DataSource = db.Soins.ToList();
            cbSoin.DisplayMember = "libelle";
            cbSoin.ValueMember = "IdSoin";

            // Charger la liste des rendez-vous dans le DataGridView
            var rendezVousList = db.RendezVous
                .Select(rv => new
                {
                    rv.IdRv,
                    rv.DateRv,
                    rv.Statut,
                    Patient = rv.patient.NomPrenom,
                    Medecin = rv.Medecin.NomPrenom,
                    Soin = rv.Soin.libelle
                })
                .ToList();
            dgRendezVous.DataSource = rendezVousList;

            // Si un médecin est sélectionné, charger ses créneaux disponibles
            if (cbMedecin.SelectedValue != null)
            {
                int idMedecin = (int)cbMedecin.SelectedValue;
                ChargerCreneaux(idMedecin);
            }
        }

        private void ChargerCreneaux(int idMedecin)
        {
            cbCreneaux.Items.Clear();
            var agenda = db.Agenda.Where(a => a.IdMedecin == idMedecin).FirstOrDefault();

            if (TimeSpan.TryParse(agenda.HeureDebut, out TimeSpan heureDebut) &&
     TimeSpan.TryParse(agenda.HeureFin, out TimeSpan heureFin))
            {
                int dureeCreneau = int.Parse(agenda.Creaneau); // Durée en minutes

                while (heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau)) <= heureFin)
                {
                    string creneau = $"{heureDebut:hh\\:mm} - {heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau)):hh\\:mm}";
                    cbCreneaux.Items.Add(creneau);
                    heureDebut = heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau)); // Avancer au créneau suivant
                }
            }
            else
            {
                MessageBox.Show($"Erreur de format de l'heure : {agenda.HeureDebut} ou {agenda.HeureFin}",
                    "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Méthode pour charger les créneaux disponibles pour le médecin
        private void LoadAvailableCreneaux(int idMedecin)
        {
            // Effacer les anciennes valeurs
            cbCreneaux.Items.Clear();

            // Charger les agendas pour ce médecin
            var agendas = db.Agenda.Where(a => a.IdMedecin == idMedecin && a.DatePlanifier >= DateTime.Now).ToList();

            foreach (var agenda in agendas)
            {
                DateTime start, end;

                // Essayer de convertir HeureDebut et HeureFin en TimeSpan
                bool startParsed = TimeSpan.TryParse(agenda.HeureDebut, out TimeSpan startTime);
                bool endParsed = TimeSpan.TryParse(agenda.HeureFin, out TimeSpan endTime);

                if (startParsed && endParsed)
                {
                    // Calculer l'heure de début et de fin à partir de la date de l'agenda et des heures spécifiées
                    start = agenda.DatePlanifier.Value.Add(startTime);
                    end = agenda.DatePlanifier.Value.Add(endTime);

                    // Parcourir les créneaux dans l'intervalle de l'agenda
                    while (start < end)
                    {
                        // Vérifier si ce créneau est déjà pris (par exemple, s'il existe déjà un rendez-vous à cette heure)
                        bool isTaken = db.RendezVous.Any(rv => rv.DateRv == start && rv.IdMedecin == idMedecin);

                        if (!isTaken)
                        {
                            // Ajouter ce créneau comme disponible
                            cbCreneaux.Items.Add(start.ToString("HH:mm"));
                        }

                        // Ajouter 30 minutes au créneau pour vérifier le suivant
                        start = start.AddMinutes(30);
                    }
                }
                else
                {
                    // Gérer l'erreur de format des horaires si nécessaire
                    Console.WriteLine($"Erreur de format dans les horaires pour l'agenda ID {agenda.IdAgenda}: {agenda.HeureDebut} ou {agenda.HeureFin}");
                }
            }

            // Sélectionner le premier créneau disponible par défaut
            if (cbCreneaux.Items.Count > 0)
            {
                cbCreneaux.SelectedIndex = 0;
            }
        }





        private void btnAjouter_Click(object sender, EventArgs e)
        {
            RendezVous rendezVous = new RendezVous
            {

                DateRv = dtpDateRv.Value,
                Statut = txtStatut.Text,
                IdPatient = (int)cbPatient.SelectedValue,
                IdMedecin = (int)cbMedecin.SelectedValue,
                IdSoin = (int)cbSoin.SelectedValue
            };

            // Ajouter le rendez-vous à la base de données
            db.RendezVous.Add(rendezVous);
            db.SaveChanges();

            // Recharger la liste des rendez-vous
            dgRendezVous.DataSource = db.RendezVous.ToList();
        }

        private void frmRendezVous_Load_1(object sender, EventArgs e)
        {

        }


        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du rendez-vous sélectionné
                int idRv = Convert.ToInt32(dgRendezVous.SelectedRows[0].Cells["IdRv"].Value);

                // Ouvrir le formulaire de ticket d'impression
               frmPrintTicket frmTicket = new frmPrintTicket(idRv);
               frmTicket.ShowDialog(); // Utilisation de ShowDialog pour que le formulaire de ticket soit modal (bloque l'accès à d'autres fenêtres tant qu'il est ouvert)
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous pour imprimer le ticket.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCreneaux.SelectedItem != null)
            {
                string[] heure = cbCreneaux.SelectedItem.ToString().Split('-');
                DateTime dateSelectionnee = dtpDateRv.Value.Date;
                TimeSpan heureDebut = TimeSpan.Parse(heure[0].Trim());

                // Enregistrer la date et l'heure choisies dans le champ DateRv
                dtpDateRv.Value = dateSelectionnee.Add(heureDebut);
            }
        }
    }
}
