using APIRvMedical.DTO;
using Newtonsoft.Json;
using priseRendezVous.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priseRendezVous.View
{
    public partial class frmRendezVous : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string apiBaseUrl;
        private readonly string apiUrl;


        public frmRendezVous()
        {
            InitializeComponent();
            apiBaseUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
            apiUrl = $"{apiBaseUrl}/rendezVous";

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Load += frmRendezVous_Load;
        }

        private async void frmRendezVous_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPatientsAsync();
                await LoadMedecinsAsync();
                await LoadSoinsAsync();
                await LoadRendezVousAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement : " + ex);
            }
        }

        private async Task LoadPatientsAsync()
        {
            var response = await _httpClient.GetAsync($"{apiBaseUrl}/patients");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var patients = JsonConvert.DeserializeObject<List<Patient>>(json);
            cbPatient.DataSource = patients;
            cbPatient.DisplayMember = "NomPrenom";
            cbPatient.ValueMember = "idU";
        }

        private async Task LoadMedecinsAsync()
        {
            var response = await _httpClient.GetAsync($"{apiBaseUrl}/medecins");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var medecins = JsonConvert.DeserializeObject<List<Medecin>>(json);
            cbMedecin.DataSource = medecins;
            cbMedecin.DisplayMember = "NomPrenom";
            cbMedecin.ValueMember = "idU";
        }

        private async Task LoadSoinsAsync()
        {
            var response = await _httpClient.GetAsync($"{apiBaseUrl}/soins");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var soins = JsonConvert.DeserializeObject<List<Soin>>(json);
            cbSoin.DataSource = soins;
            cbSoin.DisplayMember = "Libelle";
            cbSoin.ValueMember = "IdSoin";
        }

        private async Task LoadRendezVousAsync()
        {
            var response = await _httpClient.GetAsync($"{apiUrl}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var rdvs = JsonConvert.DeserializeObject<List<RendezVous>>(json);
            dgRendezVous.DataSource = rdvs;
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            var rv = GetRendezVousFromForm();
            if (rv == null) return;

            var json = JsonConvert.SerializeObject(rv);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{apiUrl}", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Rendez-vous ajouté !");
                await LoadRendezVousAsync();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout : " + response.ReasonPhrase);
            }
        }

        private async void bntModifier_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null){

                var selected = (RendezVous)dgRendezVous.CurrentRow.DataBoundItem;

                var rv = GetRendezVousFromForm();
                if (rv == null) return;

                rv.IdRv = selected.IdRv;

                var json = JsonConvert.SerializeObject(rv);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{apiUrl}/{rv.IdRv}", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Rendez-vous modifié !");
                    await LoadRendezVousAsync();
                }
                else
                {
                    MessageBox.Show("Erreur de modification : " + response.ReasonPhrase);
                }
            }
        }

        //private void btnChoisir_Click(object sender, EventArgs e)
        //{
        //    if (dgRendezVous.CurrentRow?.DataBoundItem is not RendezVousDTO selected) return;

        //    dtpDateRv.Value = selected.DateRv;
        //    txtStatut.Text = selected.Statut;
        //    cbPatient.SelectedValue = selected.IdPatient;
        //    cbMedecin.SelectedValue = selected.IdMedecin;
        //    cbSoin.SelectedValue = selected.IdSoin;
        //}

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgRendezVous.CurrentRow != null)
            {
                var selected = (RendezVous)dgRendezVous.CurrentRow.DataBoundItem;
                dtpDateRv.Value = selected.DateRv;
                txtStatut.Text = selected.Statut;
                cbPatient.SelectedValue = selected.IdPatient;
                cbMedecin.SelectedValue = selected.IdMedecin;
                cbSoin.SelectedValue = selected.IdSoin;
            }
        }

        private RendezVous GetRendezVousFromForm()
        {
            if (cbPatient.SelectedValue == null || cbMedecin.SelectedValue == null || cbSoin.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un patient, un médecin et un soin.");
                return null;
            }

            return new RendezVous
            {
                DateRv = dtpDateRv.Value,
                Statut = txtStatut.Text.Trim(),
                IdPatient = (int)cbPatient.SelectedValue,
                IdMedecin = (int)cbMedecin.SelectedValue,
                IdSoin = (int)cbSoin.SelectedValue
            };
        }

        private void dgRendezVous_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
