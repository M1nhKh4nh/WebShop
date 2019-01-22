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
    public partial class Uebersicht : System.Web.UI.Page
    {

        public Benutzer Benutzer { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Benutzer = (Benutzer)Session["Benutzer"];
            Titel.InnerText += $"{Benutzer.Benutzername}!";

            var json = RequestHelper.GetRequest("http://localhost:56058/api/Produkt/GetProdukts/");
            var produktliste = (new JavaScriptSerializer()).Deserialize<List<Produkt>>(json);
            GridViewProdukte.DataSource = produktliste;
            GridViewProdukte.DataBind();

            var json2 = RequestHelper.GetRequest($"http://localhost:56058/api/Warenkorb/GetTotalWarenkorb/{Benutzer.BenutzerId}");
            var totalCost = int.Parse(json2);
            TotalWarenkorbLabel.InnerText = $"{totalCost} CHF";
        }

        protected void GridViewProdukte_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "SeeDetails")
            {
                return;
            }

            int produktId = Convert.ToInt32(e.CommandArgument);

            Session["ProduktId"] = produktId;
            Response.Redirect("Details.aspx");    
        }

        protected void ZumWarenkorbButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("WarenkorbView.aspx");
        }
    }
}