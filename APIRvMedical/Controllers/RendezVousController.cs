using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIRvMedical.Models;

namespace APIRvMedical.Controllers
{
    public class RendezVousController : ApiController
    {
        private APIRvMedicalContext db = new APIRvMedicalContext();

        // GET: api/RendezVous
        public IQueryable<RendezVous> GetRendezvous()
        {
            return db.Rendezvous;
        }

        // GET: api/RendezVous/5
        [ResponseType(typeof(RendezVous))]
        public IHttpActionResult GetRendezVous(int id)
        {
            RendezVous rendezVous = db.Rendezvous.Find(id);
            if (rendezVous == null)
            {
                return NotFound();
            }

            return Ok(rendezVous);
        }

        // PUT: api/RendezVous/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRendezVous(int id, RendezVous rendezVous)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rendezVous.IdRv)
            {
                return BadRequest();
            }

            db.Entry(rendezVous).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RendezVousExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RendezVous
        [ResponseType(typeof(RendezVous))]
        public IHttpActionResult PostRendezVous(RendezVous rendezVous)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rendezvous.Add(rendezVous);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rendezVous.IdRv }, rendezVous);
        }

        // DELETE: api/RendezVous/5
        [ResponseType(typeof(RendezVous))]
        public IHttpActionResult DeleteRendezVous(int id)
        {
            RendezVous rendezVous = db.Rendezvous.Find(id);
            if (rendezVous == null)
            {
                return NotFound();
            }

            db.Rendezvous.Remove(rendezVous);
            db.SaveChanges();

            return Ok(rendezVous);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RendezVousExists(int id)
        {
            return db.Rendezvous.Count(e => e.IdRv == id) > 0;
        }
    }
}