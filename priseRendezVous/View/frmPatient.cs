using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Model;
namespace AppGroupe2.View
{
    public partial class frmPatient : Form
    {
        BdRvMedicalContexe db = new BdRvMedicalContexe();
        public frmPatient()
        {
            InitializeComponent();
        }
        

        public object CurrentRow { get; private set; }

        private void ResetForm()
        {
            txtNomPrenom.Text=string.Empty;
            txtAdresse.Text = string.Empty;
            txtEmail.Text=string.Empty;
            txtGroupeSanguin.Text = string.Empty;
            txtPoid.Text = string.Empty;
            txtTaille.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgPatient.DataSource = db.Patients.ToList();
            txtNomPrenom.Focus();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.NomPrenom = txtNomPrenom.Text;
            p.Adresse = txtAdresse.Text;
            p.Tel=txtTelephone.Text;
            p.Email=txtEmail.Text;
            p.Poids=float.Parse(txtTaille.Text);
            p.Taille = float.Parse(txtTaille.Text);
            p.GroupSanguin=txtGroupeSanguin.Text;
            p.DateNaissance = DateTime.Parse(txtDateNaissance.Text);
            db.Patients.Add(p);
            db.SaveChanges();
            ResetForm();


        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke; // Arrière-plan apaisant
            this.Font = new Font("Segoe UI", 10);

            // Appliquer un style moderne aux boutons
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(30, 144, 255); // Bleu doux
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                }
            }

            // Styliser le DataGridView
            dgPatient.BackgroundColor = Color.White;
            dgPatient.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgPatient.DefaultCellStyle.BackColor = Color.White;
            dgPatient.DefaultCellStyle.ForeColor = Color.Black;
            dgPatient.GridColor = Color.LightGray;
            dgPatient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgPatient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgPatient.EnableHeadersVisualStyles = false;

            ResetForm();
        }


        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text= dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text=dgPatient.CurrentRow.Cells [7].Value.ToString();
            txtTelephone.Text = dgPatient.CurrentRow.Cells[8].Value.ToString();
            txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells[0].Value.ToString() ;
            txtPoid.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtTaille.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            txtDateNaissance.Value = DateTime.TryParse(dgPatient.CurrentRow.Cells[3].Value?.ToString(), out DateTime dateNaissance)
                ? dateNaissance
                : DateTime.Now;




        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un patient à modifier.");
                return;
            }

            if (!int.TryParse(dgPatient.CurrentRow.Cells[4].Value.ToString(), out int id)) // Vérifie que l'ID est bien récupéré
            {
                MessageBox.Show("L'identifiant du patient est invalide.");
                return;
            }

            var p = db.Patients.Find(id);
            if (p != null)
            {
                p.NomPrenom = txtNomPrenom.Text;
                p.Adresse = txtAdresse.Text;
                p.Tel = txtTelephone.Text;
                p.Email = txtEmail.Text;
                p.Poids = float.Parse(txtPoid.Text);  // Correction : Utilisation de txtPoid au lieu de txtTaille
                p.Taille = float.Parse(txtTaille.Text);
                p.GroupSanguin = txtGroupeSanguin.Text;
                db.SaveChanges();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Patient non trouvé.");
            }
        }

      private void btnSupprimer_Click(object sender, EventArgs e)
{
    if (dgPatient.CurrentRow == null)
    {
        MessageBox.Show("Veuillez sélectionner un patient à supprimer.");
        return;
    }

    if (!int.TryParse(dgPatient.CurrentRow.Cells[4].Value.ToString(), out int id)) // Vérifie que l'ID est bien récupéré
    {
        MessageBox.Show("L'identifiant du patient est invalide.");
        return;
    }

    var p = db.Patients.Find(id);
    if (p == null)
    {
        MessageBox.Show("Le patient sélectionné n'existe pas dans la base de données.");
        return;
    }

    // Vérification si le patient a des rendez-vous
    if (db.RendezVous.Any(r => r.IdPatient == id))
    {
        MessageBox.Show("Ce patient a des rendez-vous enregistrés. Supprimez-les avant de supprimer le patient.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Suppression du patient
    db.Patients.Remove(p);
    db.SaveChanges();
    MessageBox.Show("Patient supprimé avec succès.");
    ResetForm();
}

        private void dgPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
