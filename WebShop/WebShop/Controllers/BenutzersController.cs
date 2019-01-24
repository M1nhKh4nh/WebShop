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

        // api/Benutzers/GetBenutzers
        public IQueryable<Benutzer> GetBenutzers()
        {
            return db.Benutzers;
        }

        // api/Benutzers/CheckBenutzer/
        [ResponseType(typeof(Benutzer))]
        public IHttpActionResult CheckBenutzer(Benutzer benutzer)
        {
            return Ok((db.Benutzers.FirstOrDefault(b => b.Benutzername == benutzer.Benutzername && b.Passwort == benutzer.Passwort)));
        }

        // api/Benutzers/GetBenutzer/5
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}