using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using priseRendezVous.Model;

namespace priseRendezVous.View
{
    public partial class frmMedecin : Form
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string apiUrl = "https://localhost:44348/api/Medecins";

        public frmMedecin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmMedecin_Load);
        }

        private async void frmMedecin_Load(object sender, EventArgs e)
        {
            await LoadMedecinsAsync();
        }

        private async System.Threading.Tasks.Task LoadMedecinsAsync()
        {
            try
            {
                var response = await client.GetAsync($"{apiUrl}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var medecins = JsonConvert.DeserializeObject<List<Medecin>>(json);
                dgMedecin.DataSource = medecins;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        public void ResetForm()
        {
            txtNomPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtSpecialite.Text = string.Empty;
            txtNumOrdre.Text = string.Empty;
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            var medecin = new Medecin
            {
                NomPrenom = txtNomPrenom.Text,
                Adresse = txtAdresse.Text,
                Tel = txtTel.Text,
                Email = txtEmail.Text,
                NumeroOrdre = txtNumOrdre.Text,
                Specialite = txtSpecialite.Text
            };

            var json = JsonConvert.SerializeObject(medecin);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{apiUrl}", content);

            if (response.IsSuccessStatusCode)
            {
                await LoadMedecinsAsync();
                ResetForm();
            }
        }

        private async void bntModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var medecin = new Medecin
            {
                idU = id,
                NomPrenom = txtNomPrenom.Text,
                Adresse = txtAdresse.Text,
                Tel = txtTel.Text,
                Email = txtEmail.Text,
                NumeroOrdre = txtNumOrdre.Text,
                Specialite = txtSpecialite.Text
            };

            var json = JsonConvert.SerializeObject(medecin);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{apiUrl}/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                await LoadMedecinsAsync();
                ResetForm();
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNomPrenom.Text = dgMedecin.CurrentRow.Cells[1].Value.ToString();
            txtAdresse.Text = dgMedecin.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgMedecin.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgMedecin.CurrentRow.Cells[4].Value.ToString();
            txtNumOrdre.Text = dgMedecin.CurrentRow.Cells[5].Value.ToString();
            txtSpecialite.Text = dgMedecin.CurrentRow.Cells[6].Value.ToString();
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var response = await client.DeleteAsync($"{apiUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                await LoadMedecinsAsync();
                ResetForm();
            }
        }
    }
}
