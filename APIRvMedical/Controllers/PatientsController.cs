using APIRvMedical.DTO;
using APIRvMedical.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace APIRvMedical.Controllers
{
    [RoutePrefix("api/patients")]
    public class PatientsController : ApiController
    {
        private APIRvMedicalContext db = new APIRvMedicalContext();

        // GET: api/patients
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var patients = db.Patients.ToList();
            return Ok(patients);
        }

        // GET: api/patients/5
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        // POST: api/patients
        [HttpPost]
        [Route("")]
        public IHttpActionResult AddPatient(PatientDto form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var patient = new Patient
            {
                NomPrenom = form.NomPrenom,
                Tel = form.Tel,
                Email = form.Email,
                Adresse = form.Adresse,
                GroupeSanguin = form.GroupeSanguin,
                Poids = form.Poids
            };

            db.Patients.Add(patient);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patient.idU }, patient);
        }

        // PUT: api/patients/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdatePatient(int id, PatientDto form)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
                return NotFound();

            patient.NomPrenom = form.NomPrenom;
            patient.Tel = form.Tel;
            patient.Email = form.Email;
            patient.Adresse = form.Adresse;
            patient.GroupeSanguin = form.GroupeSanguin;
            patient.Poids = form.Poids;

            db.Entry(patient).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(patient);
        }

        // DELETE: api/patients/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeletePatient(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
                return NotFound();

            db.Patients.Remove(patient);
            db.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}
