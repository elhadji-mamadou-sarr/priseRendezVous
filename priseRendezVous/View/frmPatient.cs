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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmPatient_Load);
        }

        BdRvMedicalContext db = new BdRvMedicalContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
            dgPatient.DataSource = db.Patients.ToList();
           
        }


        public void ResetForm()
        {
            txtNomPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtGroupSanguin.Text = string.Empty;
            txtPoids.Text = string.Empty;

            dgPatient.DataSource= db.Patients.ToList();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.NomPrenom = txtNomPrenom.Text;
            patient.Adresse = txtAdresse.Text; 
            patient.Tel = txtTel.Text;
            patient.Email = txtEmail.Text;
            patient.GroupeSanguin = txtGroupSanguin.Text;
            patient.Poids = float.Parse(txtPoids.Text);
            db.Patients.Add(patient);
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
            txtAdresse.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtTel.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtGroupSanguin.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtPoids.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
        }

        private void bntModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
            if (id.HasValue)
            {
                var patient = db.Patients.Find(id);

                patient.NomPrenom = txtNomPrenom.Text;
                patient.Adresse = txtAdresse.Text;
                patient.Tel = txtTel.Text;
                patient.Email = txtEmail.Text;
                patient.GroupeSanguin = txtGroupSanguin.Text;
                patient.Poids = float.Parse(txtPoids.Text);
                db.SaveChanges();
                ResetForm();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgPatient.CurrentRow.Cells[3].Value.ToString());
            if (id.HasValue)
            {
                var patient = db.Patients.Find(id);
                db.Patients.Remove(patient);
                ResetForm();
                db.SaveChanges();
            }
        }

        private void frmPatient_Load_1(object sender, EventArgs e)
        {
            ResetForm();
            dgPatient.DataSource = db.Patients.ToList();

        }

    }
}
