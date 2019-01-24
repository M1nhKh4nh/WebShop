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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ZurueckButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void RegistrierenButton_Click(object sender, EventArgs e)
        {
            if (PasswortTextBox.Text.Equals(PasswortBestaetigenTextBox.Text))
            {
                string apiUrl = "http://localhost:56058/api/Benutzers/InsertBenutzer/";
                var benutzer = new Benutzer()
                {
                    Benutzername = BenutzernameTextBox.Text,
                    Passwort = PasswortTextBox.Text
                };

                var json = RequestHelper.SendPostRequest(apiUrl, benutzer);               
                var newBenutzer = (new JavaScriptSerializer()).Deserialize<Benutzer>(json);

                if (newBenutzer != null)
                {
                    Session["Benutzer"] = newBenutzer;
                    Response.Redirect("Uebersicht.aspx");
                }

                else
                {
                    RegistrationErrorMessage.Text = "Dieser Benutzername ist schon vergeben.";
                }
            }
            else
            {
                RegistrationErrorMessage.Text = "Das Password wurde nicht korrekt bestätigt.";
            }
        }
    }
}