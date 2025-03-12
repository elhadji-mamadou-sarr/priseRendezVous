using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppGroupe2.Model;

namespace AppGroupe2.View
{
    public partial class frmAgenda : Form
    {
        public int idMedecin;
        private BdRvMedicalContexe db = new BdRvMedicalContexe();

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m = db.Medecins.Find(idMedecin);
            lblMedecin.Text = $"N ordre: {m.NumeroOrdre}, Nom prenom: {m.NomPrenom}";
            lblIdMedecin.Text = m.IDU.ToString();
            lblIdMedecin.Visible = false;

            // Remplir le ComboBox des créneaux (10 min d'intervalle entre 8h00 et 11h00)
            //cbCrenau.Items.Clear();
            //for (int i = 8 * 60; i <= 11 * 60; i += 10)
            //{
            //    cbCrenau.Items.Add(TimeSpan.FromMinutes(i).ToString(@"hh\:mm")); // Format correct pour TimeSpan


            //}
            //cbCrenau.SelectedIndex = 0;

            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string heureDebut = txtHeureDebut.Text;
            string heureFin = txtHeureFin.Text;
            DateTime datePlanifier = txtDateAgenda.Value;

            // Vérifier si le médecin a déjà un créneau à cette heure
            bool chevauchement = db.Agenda
     .Any(agenda => agenda.IdMedecin == idMedecin && agenda.DatePlanifier == datePlanifier &&
                    ((heureDebut.CompareTo(agenda.HeureDebut) >= 0 && heureDebut.CompareTo(agenda.HeureFin) < 0) ||
                     (heureFin.CompareTo(agenda.HeureDebut) > 0 && heureFin.CompareTo(agenda.HeureFin) <= 0)));

            if (chevauchement)
            {
                MessageBox.Show("Ce créneau chevauche un autre déjà défini pour ce médecin.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Agenda a = new Agenda
            {
                Creaneau = cbCreneau.Text,
                HeureDebut = heureDebut,
                HeureFin = heureFin,
                IdMedecin = idMedecin,
                DatePlanifier = datePlanifier,
                Statut = "brouillon",
                lieu = txtLieu.Text
            };

            db.Agenda.Add(a);
            db.SaveChanges();

            MessageBox.Show("Agenda ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ResetForm()
        {
            dgAgenda.DataSource = db.Agenda.Where(a => a.DatePlanifier >= DateTime.Now && a.IdMedecin == idMedecin).ToList();
        }
    }
}
