<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShop.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="/Style/MKWebShopStyle.css" />
    <meta charset="ISO-8859-1" />
</head>
<body>
    <div class="Header">
        <h1 class="TitleLabel">MK WebShop</h1>
    </div>
    <form id="form1" runat="server">
        <h1 id="Titel" runat="server" class="UebertitelStyle">Login </h1>
        <div class="Container">
            <p class="Labels">Benutzername:</p>
            <asp:TextBox ID="BenutzernameTextBox" runat="server" CssClass="Textfields"></asp:TextBox>

            <p class="Labels">Passwort:</p>
            <asp:TextBox ID="PasswortTextBox" runat="server" CssClass="Textfields" TextMode="Password"></asp:TextBox>

            <br />

            <asp:Button ID="RegistrierenButton" runat="server" Text="Registrieren" OnClick="RegistrierenButton_Click" CssClass="RegistrierenButtonStyle" />
            <asp:Button ID="AnmeldenButton" runat="server" Text="Anmelden" OnClick="AnmeldenButton_Click" CssClass="AnmeldenButtonStyle" />
            <br />
            <asp:Label ID="LoginFailErrorMessage" runat="server" ForeColor="Red" CssClass="ErrorMessage"></asp:Label>
        </div>
    </form>
    <div class="Footer" />
</body>
</html>
