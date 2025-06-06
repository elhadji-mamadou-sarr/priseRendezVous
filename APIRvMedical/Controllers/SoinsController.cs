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
    public class SoinsController : ApiController
    {
        private APIRvMedicalContext db = new APIRvMedicalContext();

        // GET: api/Soins
        public IQueryable<Soin> Getsoins()
        {
            return db.soins;
        }

        // GET: api/Soins/5
        [ResponseType(typeof(Soin))]
        public IHttpActionResult GetSoin(int id)
        {
            Soin soin = db.soins.Find(id);
            if (soin == null)
            {
                return NotFound();
            }

            return Ok(soin);
        }

        // PUT: api/Soins/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSoin(int id, Soin soin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != soin.IdSoin)
            {
                return BadRequest();
            }

            db.Entry(soin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoinExists(id))
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

        // POST: api/Soins
        [ResponseType(typeof(Soin))]
        public IHttpActionResult PostSoin(Soin soin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.soins.Add(soin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = soin.IdSoin }, soin);
        }

        // DELETE: api/Soins/5
        [ResponseType(typeof(Soin))]
        public IHttpActionResult DeleteSoin(int id)
        {
            Soin soin = db.soins.Find(id);
            if (soin == null)
            {
                return NotFound();
            }

            db.soins.Remove(soin);
            db.SaveChanges();

            return Ok(soin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SoinExists(int id)
        {
            return db.soins.Count(e => e.IdSoin == id) > 0;
        }
    }
}