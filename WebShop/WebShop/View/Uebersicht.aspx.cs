using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShop.Models;

namespace WebShop.View
{
    public partial class Uebersicht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var benutzer = (Benutzer)Session["Benutzer"];
            Titel.InnerText += $"{benutzer.Benutzername}!";
        }
    }
}