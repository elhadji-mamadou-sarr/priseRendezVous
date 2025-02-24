using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using priseRendezVous.View;

namespace priseRendezVous
{
    public partial class rfPatient : Form
    {
        public rfPatient()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient patientForm = new frmPatient();
            patientForm.MdiParent = this;
            patientForm.Show();
            patientForm.WindowState = FormWindowState.Maximized;
        }

        private void diponbiliteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            frmPatient patientForm = new frmPatient();
            patientForm.MdiParent = this;
            patientForm.Show();
            patientForm.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMedecin frmMedecin = new frmMedecin();
            frmMedecin.MdiParent = this;
            frmMedecin.Show();
            frmMedecin.WindowState = FormWindowState.Maximized;
        }

        private void rfPatient_Load(object sender, EventArgs e)
        {

        }

        private void medecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedecin frmMedecin = new frmMedecin();
            frmMedecin.MdiParent = this;
            frmMedecin.Show();
            frmMedecin.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Methode Pour quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment quitter le programme ?", // Message
                "Confirmation", // Titre de la boîte de dialogue
                MessageBoxButtons.OKCancel, // Boutons : OK (Quitter) et Annuler
                MessageBoxIcon.Question // Icône de question
            );

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.OK)
            {
                // Si l'utilisateur clique sur "Quitter", fermer l'application
                Application.Exit();
            }
            // Sinon, ne rien faire (la boîte de dialogue se ferme et le programme continue)
        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRendezVous frmRendezVous = new frmRendezVous();
            frmRendezVous.MdiParent = this;
            frmRendezVous.Show();
            frmRendezVous.WindowState = FormWindowState.Maximized;
        }

        private void soinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoin frmSoin = new frmSoin();
            frmSoin.MdiParent = this;
            frmSoin.Show();
            frmSoin.WindowState = FormWindowState.Maximized;
        }

        private void rendezVousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRendezVous frmRendezVous = new frmRendezVous();
            frmRendezVous.MdiParent = this;
            frmRendezVous.Show();
            frmRendezVous.WindowState = FormWindowState.Maximized;
        }
    }
}
