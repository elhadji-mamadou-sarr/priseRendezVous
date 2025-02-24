using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using priseRendezVous.Model;

namespace priseRendezVous.View
{
    public partial class frmMedecin : Form
    {
        public frmMedecin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmMedecin_Load);
        }


        BdRvMedicalContext db = new BdRvMedicalContext();

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            ResetForm();
            dgMedecin.DataSource = db.Medecins.ToList();
        }

        public void ResetForm()
        {
            txtNomPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtSpecialite.Text = string.Empty;
            txtNumOrdre.Text = string.Empty;

            dgMedecin.DataSource = db.Medecins.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Medecin medecin = new Medecin();

            medecin.NomPrenom = txtNomPrenom.Text;
            medecin.Adresse = txtAdresse.Text;
            medecin.Tel = txtTel.Text;
            medecin.Email = txtEmail.Text;
            medecin.NumeroOrdre = txtNumOrdre.Text;
            medecin.Specialite = txtSpecialite.Text;
            db.Medecins.Add(medecin);
            db.SaveChanges();
            ResetForm();

        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[3].Value.ToString());
            if (id.HasValue)
            {
                var medecin = db.Medecins.Find(id);

                medecin.NomPrenom = txtNomPrenom.Text;
                medecin.Adresse = txtAdresse.Text;
                medecin.Tel = txtTel.Text;
                medecin.Email = txtEmail.Text;
                medecin.NumeroOrdre = txtNumOrdre.Text;
                medecin.Specialite = txtSpecialite.Text;
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgMedecin.CurrentRow.Cells[4].Value.ToString();
            txtAdresse.Text = dgMedecin.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgMedecin.CurrentRow.Cells[6].Value.ToString();
            txtTel.Text = dgMedecin.CurrentRow.Cells[5].Value.ToString();
            txtSpecialite.Text = dgMedecin.CurrentRow.Cells[0].Value.ToString();
            txtNumOrdre.Text = dgMedecin.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[3].Value.ToString());
            if (id.HasValue)
            {
                var medecin = db.Medecins.Find(id);
                db.Medecins.Remove(medecin);
                ResetForm();
                db.SaveChanges();
            }
        }

    }

}
