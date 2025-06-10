using Newtonsoft.Json;
using priseRendezVous.helper;
using priseRendezVous.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// Bouton pour se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
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
                var utilisateur = await AuthentifierUtilisateurAsync(identifiant, motDePasse);
                if (utilisateur != null)
                {
                    OuvrirInterfaceSelonRole(utilisateur);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Utilisateur> AuthentifierUtilisateurAsync(string identifiant, string motDePasse)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44348/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var loginInfo = new
                {
                    Identifiant = identifiant,
                    MotDePasse = motDePasse // Non hashé ici, c’est l’API qui hash
                };

                string jsonData = JsonConvert.SerializeObject(loginInfo);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var utilisateur = JsonConvert.DeserializeObject<Utilisateur>(json);
                    return utilisateur;
                }

                return null;
            }
        }


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
