using AppGroupe2.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppGroupe2.View
{
    public partial class frmRendezVous : Form
    {
        BdRvMedicalContexe db = new BdRvMedicalContexe();

        public frmRendezVous()
        {
            InitializeComponent();
            this.Load += frmRendezVous_Load;

            // Bouton Imprimer
            btnImprimer = new Button
            {
                Location = new System.Drawing.Point(150, 450),
                Name = "btnImprimer",
                Size = new System.Drawing.Size(100, 30),
                Text = "Imprimer",
                UseVisualStyleBackColor = true
            };
            btnImprimer.Click += btnImprimer_Click;
            Controls.Add(btnImprimer);
        }

        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            // Charger les données
            cbPatient.DataSource = db.Patients.ToList();
            cbPatient.DisplayMember = "NomPrenom";
            cbPatient.ValueMember = "IDU";

            cbMedecin.DataSource = db.Medecins.ToList();
            cbMedecin.DisplayMember = "NomPrenom";
            cbMedecin.ValueMember = "IDU";

            cbSoin.DataSource = db.Soins.ToList();
            cbSoin.DisplayMember = "libelle";
            cbSoin.ValueMember = "IdSoin";

            // Charger les rendez-vous
            RefreshRendezVousList();
            cbMedecin.SelectedIndexChanged += cbMedecin_SelectedIndexChanged;
        }

        private void RefreshRendezVousList()
        {
            dgRendezVous.DataSource = db.RendezVous.Select(rv => new
            {
                rv.IdRv,
                rv.DateRv,
                rv.Statut,
                Patient = rv.patient.NomPrenom,
                Medecin = rv.Medecin.NomPrenom,
                Soin = rv.Soin.libelle
            }).ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var rendezVous = new RendezVous
            {
                DateRv = dtpDateRv.Value,
                Statut = txtStatut.Text,
                IdPatient = (int)cbPatient.SelectedValue,
                IdMedecin = (int)cbMedecin.SelectedValue,
                IdSoin = (int)cbSoin.SelectedValue
            };

            db.RendezVous.Add(rendezVous);
            db.SaveChanges();
            RefreshRendezVousList();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.SelectedRows.Count > 0)
            {
                int idRv = Convert.ToInt32(dgRendezVous.SelectedRows[0].Cells["IdRv"].Value);
                frmPrintTicket frmTicket = new frmPrintTicket(idRv);
                frmTicket.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous pour imprimer le ticket.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMedecin.SelectedValue != null)
            {
                int idMedecin = (int)cbMedecin.SelectedValue;
                ChargerCreneaux(idMedecin);
            }
        }

        private void ChargerCreneaux(int idMedecin)
        {
            lbCreneau.Items.Clear();
            var agenda = db.Agenda.FirstOrDefault(a => a.IdMedecin == idMedecin);

            if (agenda == null) return;

            if (TimeSpan.TryParse(agenda.HeureDebut, out TimeSpan heureDebut) &&
                TimeSpan.TryParse(agenda.HeureFin, out TimeSpan heureFin) &&
                int.TryParse(agenda.Creaneau, out int dureeCreneau) && dureeCreneau > 0)
            {
                while (heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau)) <= heureFin)
                {
                    lbCreneau.Items.Add($"{heureDebut:hh\\:mm} - {heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau)):hh\\:mm}");
                    heureDebut = heureDebut.Add(TimeSpan.FromMinutes(dureeCreneau));
                }
            }
            else
            {
                MessageBox.Show("Erreur de format des horaires ou durée de créneau invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
