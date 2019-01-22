using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShop.Helper;
using WebShop.Models;

namespace WebShop.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistrierenButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void AnmeldenButton_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://localhost:56058/api/Benutzers/CheckBenutzer/";
            var benutzer = new Benutzer()
            {
                Benutzername = BenutzernameTextBox.Text,
                Passwort = PasswortTextBox.Text
            };

            var json = RequestHelper.SendPostRequest(apiUrl, benutzer);
            var benutzerInDb = (new JavaScriptSerializer()).Deserialize<Benutzer>(json);

            if (benutzerInDb != null)
            {
                Session["Benutzer"] = benutzerInDb;
                Response.Redirect("Uebersicht.aspx");
            }
            else
            {
                LoginFailErrorMessage.Text = "Benutzername oder Passwort ist falsch";
            }
            
        }
    }
}