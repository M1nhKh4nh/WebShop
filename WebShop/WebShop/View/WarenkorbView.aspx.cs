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
    public partial class WarenkorbView : System.Web.UI.Page
    {
        public Benutzer Benutzer { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Benutzer = (Benutzer)Session["Benutzer"];

            if (Benutzer != null)
            {
                var json = RequestHelper.GetRequest($"http://localhost:56058/api/Warenkorb/GetWarenkorb/{Benutzer.BenutzerId}");
                var produktliste = (new JavaScriptSerializer()).Deserialize<List<Warenkorb>>(json);

                var json2 = RequestHelper.GetRequest($"http://localhost:56058/api/Warenkorb/GetTotalWarenkorb/{Benutzer.BenutzerId}");
                var totalCost = int.Parse(json2);
                TotalWarenkorbLabel.InnerText = $"Total: {totalCost} CHF";

                GridViewWarenkorb.DataSource = produktliste;
                GridViewWarenkorb.DataBind();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void ZurueckButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Uebersicht.aspx");
        }
    }
}