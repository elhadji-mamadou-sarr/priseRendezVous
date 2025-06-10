using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using priseRendezVous.Model;

namespace priseRendezVous.helper
{
    public class ApiMedical
    {

        public async Task<Utilisateur> AuthentifierUtilisateurAsync(string identifiant, string motDePasse)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44348/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var loginInfo = new
                {
                    Identifiant = identifiant,
                    MotDePasse = motDePasse
                };

                string jsonData = JsonConvert.SerializeObject(loginInfo);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("auth/login", content);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var utilisateur = JsonConvert.DeserializeObject<Utilisateur>(json);
                    return utilisateur;
                }

                return null;
            }
        }



    }



}
