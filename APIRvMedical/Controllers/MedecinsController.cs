using APIRvMedical.Models;
using APIRvMedical.DTO;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace APIRvMedical.Controllers
{
    [RoutePrefix("api/medecins")]
    public class MedecinsController : ApiController
    {
        private APIRvMedicalContext db = new APIRvMedicalContext();

        // GET: api/medecins
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var medecins = db.Medecins.ToList();
            return Ok(medecins);
        }

        // GET: api/medecins/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
                return NotFound();

            return Ok(medecin);
        }

        // POST: api/medecins
        [HttpPost]
        [Route("")]
        public IHttpActionResult AddMedecin(MedecinDto form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var medecin = new Medecin
            {
                NomPrenom = form.NomPrenom,
                Tel = form.Tel,
                Email = form.Email,
                Adresse = form.Adresse,
                Specialite = form.Specialite,
                NumeroOrdre = form.NumeroOrdre
            };

            db.Medecins.Add(medecin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medecin.idU }, medecin);
        }

        // PUT: api/medecins/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateMedecin(int id, MedecinDto form)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
                return NotFound();

            medecin.NomPrenom = form.NomPrenom;
            medecin.Tel = form.Tel;
            medecin.Email = form.Email;
            medecin.Adresse = form.Adresse;
            medecin.Specialite = form.Specialite;
            medecin.NumeroOrdre = form.NumeroOrdre;

            db.Entry(medecin).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(medecin);
        }

        // DELETE: api/medecins/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteMedecin(int id)
        {
            var medecin = db.Medecins.Find(id);
            if (medecin == null)
                return NotFound();

            db.Medecins.Remove(medecin);
            db.SaveChanges();

            return Ok();
        }
    }
}
