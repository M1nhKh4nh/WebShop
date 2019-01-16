<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebShop.View.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <h1>Login</h1>
        <p>Benutzername</p>
        <asp:TextBox ID="BenutzernameTextBox" runat="server"></asp:TextBox>
        <p>Passwort</p>
        <asp:TextBox ID="PasswortTextBox" runat="server"></asp:TextBox>
        <p>Passwort</p>
        <asp:TextBox ID="PasswortBestaetigenTextBox" runat="server"></asp:TextBox>

        <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click"/>
        <asp:Button  ID="RegistrierenButton" runat="server" Text="Registrieren" />
    </div>
    </div>
    </form>
</body>
</html>
