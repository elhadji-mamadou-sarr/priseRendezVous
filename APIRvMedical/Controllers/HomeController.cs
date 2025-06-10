using APIRvMedical.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace APIRvMedical.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Page d'accueil";

            //try
            //{
            //    using (var context = new APIRvMedicalContext())
            //    {
            //        if (!context.Admins.Any())
            //        {
            //            var admin = new Admin
            //            {
            //                Adresse = "ligne",
            //                Email = "admin@gmail.com",
            //                NomPrenom = "Admin",
            //                Identifiant = "admin@gmail.com",
            //                MotDePasse = CryptString.GetMd5Hash("0000"),
            //                Statut = true,
            //                Tel = "743829"
            //            };

            //            context.Admins.Add(admin);
            //            context.SaveChanges();
            //            ViewBag.Message = "Admin créé avec succès !";
            //        }
            //        else
            //        {
            //            ViewBag.Message = "Admin déjà existant.";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = $"Erreur lors de la création de l'admin : {ex.Message}";
            //}

            return View();
        }
    }
}
