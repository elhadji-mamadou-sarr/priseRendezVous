using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIRvMedical.Models;
using priseRendezVous.helper;
using priseRendezVous.Model;

namespace priseRendezVous
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreateAdmin();

            Application.Run(new Form1());

            using (var context = new APIRvMedicalContext())
            {

                Console.WriteLine("Connexion à la base de données réussie !");
            }
        }


         static void CreateAdmin()
        {
            try
            {
                using (var context = new APIRvMedicalContext())
                {
                    if (!context.Admins.Any()) 
                    {
                        var admin = new APIRvMedical.Models.Admin
                        {
                            Adresse = "ligne",
                            Email = "admin@gmail.com",
                            NomPrenom = "Admin",
                            Identifiant = "admin@gmail.com",
                            MotDePasse = CryptString.GetMd5Hash("0000"),
                            Statut = true,
                            Tel = "743829"
                        };

                        context.Admins.Add(admin);
                        context.SaveChanges();
                        Console.WriteLine("Admin créé avec succès !");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur création admin: {ex.Message}");
            }
        }


    }
}
