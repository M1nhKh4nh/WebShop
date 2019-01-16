<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShop.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>
        <p>Benutzername</p>
        <asp:TextBox ID="BenutzernameTextBox" runat="server"></asp:TextBox>
        <p>Passwort</p>
        <asp:TextBox ID="PasswortTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="RegistrierenButton" runat="server" Text="Registrieren" OnClick="RegistrierenButton_Click"/>
        <asp:Button  ID="AnmeldenButton" runat="server" Text="Anmelden" OnClick="AnmeldenButton_Click"/>
        <br />
        <asp:Label ID="LoginFailErrorMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
