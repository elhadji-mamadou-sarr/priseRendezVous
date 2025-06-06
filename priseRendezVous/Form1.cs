using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using priseRendezVous.helper;
using priseRendezVous.Model;

namespace priseRendezVous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxMotDePasse.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIdentifiant.Text.Trim();
            string motDePasse = textBoxMotDePasse.Text;

            if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez saisir l'identifiant et le mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new BdRvMedicalContext())
                {
                    // Récupérer le hash MD5 du mot de passe saisi
                    string motDePasseHash = CryptString.GetMd5Hash(motDePasse);

                    // Vérifier les identifiants
                    var utilisateur = context.utilisateurs
                        .FirstOrDefault(u => u.Identifiant == identifiant && u.MotDePasse == motDePasseHash);

                    if (utilisateur != null)
                    {
                        // Authentification réussie
                        OuvrirInterfaceSelonRole(utilisateur);
                        this.Hide(); // Cache le formulaire de connexion
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //rfPatient frmPatient = new rfPatient ();
            //frmPatient.Show();
            //this.Hide();
        

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OuvrirInterfaceSelonRole(Utilisateur utilisateur)
        {
           

            if (utilisateur is Admin)
            {
                rfPatient frmPatient = new rfPatient();
                frmPatient.Show();
                //var formAdmin = new frmAdminInterface();
                //formAdmin.Show();
            }
            else if (utilisateur is Medecin)
            {
                //var formMedecin = new frmMedecinInterface();
                //formMedecin.Show();
            }
            else if (utilisateur is Secretaire)
            {
                //var formSecretaire = new frmSecretaireInterface();
                //formSecretaire.Show();
            }
            else
            {
                rfPatient frmPatient = new rfPatient();
                frmPatient.Show();
               // MessageBox.Show("Votre rôle ne vous permet pas d'accéder au système", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // this.Show(); // Affiche à nouveau le formulaire de connexion
            }
        }



    }
}
