using APIRvMedical.Models;
using APIRvMedical.DTO;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;

namespace APIRvMedical.Controllers
{
    public class RendezVousController : ApiController
    {
        private readonly APIRvMedicalContext db = new APIRvMedicalContext();

        // GET: api/RendezVous
        public IQueryable<RendezVousDTO> GetRendezVous()
        {
            return db.Rendezvous.Select(rv => new RendezVousDTO
            {
                IdRv = rv.IdRv,
                DateRv = rv.DateRv,
                Statut = rv.Statut,
                IdPatient = (int)rv.IdPatient,
                IdMedecin = (int)rv.IdMedecin,
                IdSoin = (int)rv.IdSoin
            });
        }

        // GET: api/RendezVous/5
        [ResponseType(typeof(RendezVousDTO))]
        public IHttpActionResult GetRendezVous(int id)
        {
            var rv = db.Rendezvous.Find(id);
            if (rv == null) return NotFound();

            var dto = new RendezVousDTO
            {
                IdRv = rv.IdRv,
                DateRv = rv.DateRv,
                Statut = rv.Statut,
                IdPatient = (int)rv.IdPatient,
                IdMedecin = (int)rv.IdMedecin,
                IdSoin = (int)rv.IdSoin
            };

            return Ok(dto);
        }

        // PUT: api/RendezVous/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRendezVous(int id, RendezVousDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != dto.IdRv) return BadRequest("Identifiants différents.");

            var rv = db.Rendezvous.Find(id);
            if (rv == null) return NotFound();

            rv.DateRv = dto.DateRv;
            rv.Statut = dto.Statut;
            rv.IdPatient = dto.IdPatient;
            rv.IdMedecin = dto.IdMedecin;
            rv.IdSoin = dto.IdSoin;

            db.Entry(rv).State = EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RendezVous
        [ResponseType(typeof(RendezVousDTO))]
        public IHttpActionResult PostRendezVous(RendezVousDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var rv = new RendezVous
            {
                DateRv = dto.DateRv,
                Statut = dto.Statut,
                IdPatient = dto.IdPatient,
                IdMedecin = dto.IdMedecin,
                IdSoin = dto.IdSoin
            };

            db.Rendezvous.Add(rv);
            db.SaveChanges();
            dto.IdRv = rv.IdRv;

            return CreatedAtRoute("DefaultApi", new { id = rv.IdRv }, dto);
        }

        // DELETE: api/RendezVous/5
        [ResponseType(typeof(void))]
        public IHttpActionResult DeleteRendezVous(int id)
        {
            var rv = db.Rendezvous.Find(id);
            if (rv == null) return NotFound();

            db.Rendezvous.Remove(rv);
            db.SaveChanges();

            return Ok();
        }
    }
}
