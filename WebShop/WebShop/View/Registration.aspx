<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebShop.View.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Style/MKWebShopStyle.css"/>
    <meta charset="ISO-8859-1"/> 
</head>
<body>
    <div class="Header">
        <h1 class="TitleLabel">MK WebShop</h1>
    </div>

    <form id="form1" runat="server">
    <h1 runat="server" class="UebertitelStyle">Registrieren </h1>
    <div class="Container">
        
        <p class="Labels">Benutzername:</p>
        <asp:TextBox ID="BenutzernameTextBox" runat="server" CssClass="Textfields"></asp:TextBox>
        <p class="Labels">Passwort:</p>
        <asp:TextBox ID="PasswortTextBox" runat="server" CssClass="Textfields" TextMode="Password"></asp:TextBox>
        <p class="Labels">Passwort bestätigen:</p>
        <asp:TextBox ID="PasswortBestaetigenTextBox" runat="server" CssClass="Textfields" TextMode="Password"></asp:TextBox>

        <br />

        <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click" CssClass="ZurueckButtonStyle"/>
        <asp:Button  ID="RegistrierenButton" runat="server" Text="Registrieren" OnClick="RegistrierenButton_Click" CssClass="RegistrierenButtonStyleGreen"/>

        <asp:Label ID="RegistrationErrorMessage" runat="server" ForeColor="Red" CssClass="ErrorMessage"></asp:Label>

    </div>
    </form>
    <div class="Footer"/>
</body>
</html>
