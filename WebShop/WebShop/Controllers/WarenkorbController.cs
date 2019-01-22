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
    public class WarenkorbController : ApiController
    {
        private WebShopDataContext db = new WebShopDataContext();

        public IQueryable<Warenkorb> GetWarenkorb()
        {
            return db.Warenkorbs;
        }

        [ResponseType(typeof(int))]
        public IHttpActionResult GetTotalWarenkorb(int id)
        {
            var warenkorb = db.Warenkorbs.Where(w => w.FK_BenutzerId.Equals(id)).ToList();
            if (warenkorb == null || warenkorb.Count == 0)
            {
                return Ok(0);
            }
            else
            {
                var totalCost = 0;
                warenkorb.ForEach(w => totalCost += w.Produkt.Preis.Value);
                return Ok(totalCost);
            }      
        }

        [ResponseType(typeof(List<Warenkorb>))]
        public IHttpActionResult GetWarenkorb(int id)
        {
            var warenkorb = db.Warenkorbs.Where(w=> w.FK_BenutzerId.Equals(id)).ToList();
            if (warenkorb == null)
            {
                return NotFound();
            }

            return Ok(warenkorb);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutWarenkorb(int id, Warenkorb warenkorb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != warenkorb.Id)
            {
                return BadRequest();
            }

            db.Entry(warenkorb).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WarenkorbExists(id))
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

        [ResponseType(typeof(Warenkorb))]
        public IHttpActionResult PostWarenkorb(Warenkorb warenkorb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Warenkorbs.Add(warenkorb);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WarenkorbExists(warenkorb.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(warenkorb);
        }

        [ResponseType(typeof(Warenkorb))]
        public IHttpActionResult DeleteWarenkorb(int id)
        {
            Warenkorb warenkorb = db.Warenkorbs.Find(id);
            if (warenkorb == null)
            {
                return NotFound();
            }

            db.Warenkorbs.Remove(warenkorb);
            db.SaveChanges();

            return Ok(warenkorb);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WarenkorbExists(int id)
        {
            return db.Warenkorbs.Count(e => e.Id == id) > 0;
        }
    }
}