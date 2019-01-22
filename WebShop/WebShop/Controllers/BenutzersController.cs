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
using WebShop.Models;

namespace WebShop.Controllers
{
    public class BenutzersController : ApiController
    {
        private WebShopDataContext db = new WebShopDataContext();

        // GET: api/Benutzers
        public IQueryable<Benutzer> GetBenutzers()
        {
            return db.Benutzers;
        }

        // GET: api/Benutzers/CheckBenutzer/...
        [ResponseType(typeof(Benutzer))]
        public IHttpActionResult CheckBenutzer(Benutzer benutzer)
        {
            return Ok((db.Benutzers.FirstOrDefault(b => b.Benutzername == benutzer.Benutzername && b.Passwort == benutzer.Passwort)));
        }

        // GET: api/Benutzers/5
        [ResponseType(typeof(Benutzer))]
        public IHttpActionResult GetBenutzer(int id)
        {
            Benutzer benutzer = db.Benutzers.Find(id);
            if (benutzer == null)
            {
                return NotFound();
            }

            return Ok(benutzer);
        }

        // PUT: api/Benutzers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBenutzer(int id, Benutzer benutzer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != benutzer.BenutzerId)
            {
                return BadRequest();
            }

            db.Entry(benutzer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BenutzerExists(id))
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

        // POST: api/Benutzers/InsertBenutzer
        [ResponseType(typeof(Benutzer))]
        public IHttpActionResult InsertBenutzer(Benutzer benutzer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!db.Benutzers.Any(b => b.Benutzername.Equals(benutzer.Benutzername)))
            {
                db.Benutzers.Add(benutzer);
                db.SaveChanges();

                return Ok(benutzer);
            }
            else
            {
                return Ok((Benutzer)null);
            }
        }

        // DELETE: api/Benutzers/5
        [ResponseType(typeof(Benutzer))]
        public IHttpActionResult DeleteBenutzer(int id)
        {
            Benutzer benutzer = db.Benutzers.Find(id);
            if (benutzer == null)
            {
                return NotFound();
            }

            db.Benutzers.Remove(benutzer);
            db.SaveChanges();

            return Ok(benutzer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BenutzerExists(int id)
        {
            return db.Benutzers.Count(e => e.BenutzerId == id) > 0;
        }
    }
}