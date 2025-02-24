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
    public partial class frmRendezVous : Form
    {
        public frmRendezVous()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmRendezVous_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        BdRvMedicalContext db = new BdRvMedicalContext();

        private void frmRendezVous_Load(object sender, EventArgs e)
        {
            // Charger les patients dans le ComboBox
            cbPatient.DataSource = db.Patients.ToList();
            cbPatient.DisplayMember = "NomPrenom"; // Afficher le nom du patient
            cbPatient.ValueMember = "idU"; // Utiliser l'ID du patient comme valeur

            // Charger les médecins dans le ComboBox
            cbMedecin.DataSource = db.Medecins.ToList();
            cbMedecin.DisplayMember = "NomPrenom"; // Afficher le nom du médecin
            cbMedecin.ValueMember = "idU"; // Utiliser l'ID du médecin comme valeur

            // Charger les soins dans le ComboBox
            cbSoin.DataSource = db.soins.ToList();
            cbSoin.DisplayMember = "libelle"; // Afficher le nom du soin
            cbSoin.ValueMember = "IdSoin"; // Utiliser l'ID du soin comme valeur

            // Charger la liste des rendez-vous dans le DataGridView
            dgRendezVous.DataSource = db.rendezvous.ToList();
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
            db.rendezvous.Add(rendezVous);
            db.SaveChanges();

            // Recharger la liste des rendez-vous
            dgRendezVous.DataSource = db.rendezvous.ToList();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {

        }

        private void bntModifier_Click(object sender, EventArgs e)
        {

        }
    }
}
