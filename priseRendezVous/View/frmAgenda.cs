using System;
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
            if (m != null)
            {
                lblMedecin.Text = $"N° Ordre: {m.NumeroOrdre}, Nom Prénom: {m.NomPrenom}";
                lblIdMedecin.Text = m.IDU.ToString();
                lblIdMedecin.Visible = false;
            }

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

            // Ajout du créneau
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
            db = new BdRvMedicalContexe();
            dgAgenda.DataSource = null;
            dgAgenda.DataSource = db.Agenda.ToList(); // Affiche tout
            dgAgenda.Refresh();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAgenda.SelectedRows.Count > 0)
            {
                int idAgenda = Convert.ToInt32(dgAgenda.SelectedRows[0].Cells["IdAgenda"].Value);

                var agenda = db.Agenda.Find(idAgenda);
                if (agenda != null)
                {
                    db.Agenda.Remove(agenda);
                    db.SaveChanges();
                    MessageBox.Show("Créneau supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un créneau à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgAgenda.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un créneau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtTitre.Text = dgAgenda.CurrentRow.Cells["Creaneau"].Value.ToString();
            txtHeureDebut.Text = dgAgenda.CurrentRow.Cells["HeureDebut"].Value.ToString();
            txtHeureFin.Text = dgAgenda.CurrentRow.Cells["HeureFin"].Value.ToString();
            txtDateAgenda.Value = Convert.ToDateTime(dgAgenda.CurrentRow.Cells["DatePlanifier"].Value);
            txtLieu.Text = dgAgenda.CurrentRow.Cells["Lieu"].Value.ToString();
            cbCreneau.Text = dgAgenda.CurrentRow.Cells["Creaneau"].Value.ToString();
        }
    }

}
    

    

