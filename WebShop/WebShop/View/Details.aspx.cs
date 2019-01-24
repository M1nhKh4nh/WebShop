using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShop.Helper;
using WebShop.Models;

namespace WebShop.View
{
    public partial class Details : System.Web.UI.Page
    {
        public Produkt Produkt { get; set; }
        public Benutzer Benutzer { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var produktId = -1;
            try
            {
                produktId = (int)Session["ProduktId"];
                Benutzer = (Benutzer)Session["Benutzer"];
            }

            catch(Exception)
            {
                Response.Redirect("Login.aspx");
            }

            //Hole das Produkt aus der Datenbank, der den User auswählte
            var json = RequestHelper.GetRequest($"http://localhost:56058/api/Produkt/GetProdukt/{produktId}");
            Produkt = (new JavaScriptSerializer()).Deserialize<Produkt>(json);

            ProduktnameLabel.InnerText = Produkt.Produktname;
            ProduktbeschreibungLabel.InnerText = Produkt.Produktbeschreibung;
            PreisLabel.InnerText = Produkt.Preis.ToString();
        }

        protected void IndenWarenkorbButton_Click(object sender, EventArgs e)
        {
            var warenkorb = new Warenkorb();
            warenkorb.FK_BenutzerId = Benutzer.BenutzerId;
            warenkorb.FK_ProduktId = Produkt.ProduktId;

            //Füge das Produkt in den Warenkorb hinzu
            RequestHelper.SendPostRequest("http://localhost:56058/api/Warenkorb/PostWarenkorb/", warenkorb);
            Response.Redirect("Uebersicht.aspx");
        }

        protected void ZurueckButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Uebersicht.aspx");
        }
    }
}