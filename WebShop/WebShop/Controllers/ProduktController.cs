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
    public class ProduktController : ApiController
    {
        private WebShopDataContext db = new WebShopDataContext();

        // api/Produkt/GetProdukts
        public IQueryable<Produkt> GetProdukts()
        {
            return db.Produkts;
        }

        // api/Produkt/GetProdukt/5
        [ResponseType(typeof(Produkt))]
        public IHttpActionResult GetProdukt(int id)
        {
            Produkt produkt = db.Produkts.Find(id);
            if (produkt == null)
            {
                return NotFound();
            }

            return Ok(produkt);
        }

        // api/Produkt/PostProdukt
        [ResponseType(typeof(Produkt))]
        public IHttpActionResult PostProdukt(Produkt produkt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Produkts.Add(produkt);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produkt.ProduktId }, produkt);
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