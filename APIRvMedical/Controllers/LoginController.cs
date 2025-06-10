using APIRvMedical.DTO;
using APIRvMedical.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRvMedical.Controllers
{
    public class LoginController : ApiController
    {


        [HttpPost]
        [Route("api/auth/login")]
        public IHttpActionResult Login([FromBody] LoginDto model)
        {
            if (model == null || string.IsNullOrEmpty(model.Identifiant) || string.IsNullOrEmpty(model.MotDePasse))
                return BadRequest("Identifiant ou mot de passe manquant");

            APIRvMedicalContext db = new APIRvMedicalContext();
            string hash = CryptString.GetMd5Hash(model.MotDePasse);

            var utilisateur = db.Utilisateurs
                .FirstOrDefault(u => u.Identifiant == model.Identifiant && u.MotDePasse == hash);

            if (utilisateur == null)
                return Unauthorized();

            // On peut renvoyer un DTO au lieu de l'objet brut
            var result = new
            {
                utilisateur.idU,
                utilisateur.Identifiant,
                utilisateur.NomPrenom,
                utilisateur.Email,
            };

            return Ok(result);
        }
    }
}
