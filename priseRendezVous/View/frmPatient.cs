using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using priseRendezVous.Model;

namespace priseRendezVous.View
{
    public partial class frmPatient : Form
    {
        private readonly HttpClient client = new HttpClient();
        private const string baseUrl = "https://localhost:44348/api/patients"; 

        public frmPatient()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            this.Load += new EventHandler(frmPatient_Load);
        }

        private async void frmPatient_Load(object sender, EventArgs e)
        {
            await LoadPatients();
        }

        private async System.Threading.Tasks.Task LoadPatients()
        {
            var response = await client.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var patients = JsonConvert.DeserializeObject<List<Patient>>(jsonData);
                dgPatient.DataSource = patients;
            }
            else
            {
                MessageBox.Show("Erreur lors du chargement des patients");
            }
        }

        private void ResetForm()
        {
            txtNomPrenom.Text = "";
            txtEmail.Text = "";
            txtAdresse.Text = "";
            txtTel.Text = "";
            txtGroupSanguin.Text = "";
            txtPoids.Text = "";
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                NomPrenom = txtNomPrenom.Text,
                Adresse = txtAdresse.Text,
                Tel = txtTel.Text,
                Email = txtEmail.Text,
                GroupeSanguin = txtGroupSanguin.Text,
                Poids = float.Parse(txtPoids.Text)
            };

            try { 
                var json = JsonConvert.SerializeObject(patient);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(baseUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Patient ajouté !");
                    await LoadPatients();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de l'ajout : " + ex.Message);
            }

          
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                txtNomPrenom.Text = dgPatient.CurrentRow.Cells["NomPrenom"].Value.ToString();
                txtAdresse.Text = dgPatient.CurrentRow.Cells["Adresse"].Value.ToString();
                txtEmail.Text = dgPatient.CurrentRow.Cells["Email"].Value.ToString();
                txtTel.Text = dgPatient.CurrentRow.Cells["Tel"].Value.ToString();
                txtGroupSanguin.Text = dgPatient.CurrentRow.Cells["GroupeSanguin"].Value.ToString();
                txtPoids.Text = dgPatient.CurrentRow.Cells["Poids"].Value.ToString();
            }
        }

        private async void bntModifier_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow == null) return;

            int id = (int)dgPatient.CurrentRow.Cells["idU"].Value;
            var patient = new Patient
            {
                idU = id,
                NomPrenom = txtNomPrenom.Text,
                Adresse = txtAdresse.Text,
                Tel = txtTel.Text,
                Email = txtEmail.Text,
                GroupeSanguin = txtGroupSanguin.Text,
                Poids = float.Parse(txtPoids.Text)
            };

            var json = JsonConvert.SerializeObject(patient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"{baseUrl}/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient modifié !");
                await LoadPatients();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification");
            }
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow == null) return;

            int id = (int)dgPatient.CurrentRow.Cells["idU"].Value;
            var response = await client.DeleteAsync($"{baseUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient supprimé !");
                await LoadPatients();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression");
            }
        }

        private void frmPatient_Load_1(object sender, EventArgs e)
        {

        }
    }
}
