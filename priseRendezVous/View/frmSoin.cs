using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using priseRendezVous.Model;

namespace priseRendezVous.View
{
    public partial class frmSoin : Form
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string apiUrl = "https://localhost:44348/api/Soins";

        public frmSoin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSoin_Load);
        }

        private async void frmSoin_Load(object sender, EventArgs e)
        {
            await LoadSoinsAsync();
        }

        private async System.Threading.Tasks.Task LoadSoinsAsync()
        {
            try
            {
                var response = await client.GetAsync($"{apiUrl}/Getsoins");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var soins = JsonConvert.DeserializeObject<List<Soin>>(json);
                dgSoin.DataSource = soins;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtLibelle.Text = string.Empty;
            txtCout.Text = string.Empty;
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || string.IsNullOrWhiteSpace(txtCout.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!float.TryParse(txtCout.Text, out float cout))
            {
                MessageBox.Show("Le coût doit être un nombre valide.");
                return;
            }

            var soin = new Soin
            {
                libelle = txtLibelle.Text,
                cout = cout
            };

            try
            {
                var json = JsonConvert.SerializeObject(soin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{apiUrl}/PostSoin", content);

                if (response.IsSuccessStatusCode)
                {
                    await LoadSoinsAsync();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }
        }

        private async void bntModifier_Click(object sender, EventArgs e)
        {
            if (dgSoin.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un soin.");
                return;
            }

            if (!int.TryParse(dgSoin.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("ID invalide.");
                return;
            }

            if (!float.TryParse(txtCout.Text, out float cout))
            {
                MessageBox.Show("Le coût doit être un nombre valide.");
                return;
            }

            var soin = new Soin
            {
                IdSoin = id,
                libelle = txtLibelle.Text,
                cout = cout
            };

            try
            {
                var json = JsonConvert.SerializeObject(soin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"{apiUrl}/PutSoin/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    await LoadSoinsAsync();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Échec de la modification.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if (dgSoin.CurrentRow != null)
            {
                txtLibelle.Text = dgSoin.CurrentRow.Cells[1].Value.ToString();
                txtCout.Text = dgSoin.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private async void bntSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoin.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un soin à supprimer.");
                return;
            }

            if (!int.TryParse(dgSoin.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("ID invalide.");
                return;
            }

            var confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce soin ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await client.DeleteAsync($"{apiUrl}/DeleteSoin/{id}");

                if (response.IsSuccessStatusCode)
                {
                    await LoadSoinsAsync();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
            }
        }
    }
}
