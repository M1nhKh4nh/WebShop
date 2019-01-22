<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebShop.View.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Produktname: </p>
        <p id="ProduktnameLabel" runat="server"></p>

        <p>Produktbeschreibung: </p>
        <p id="ProduktbeschreibungLabel" runat="server"></p>

        <asp:Button ID="IndenWarenkorbButton" runat="server" Text="In den Warenkorb" OnClick="IndenWarenkorbButton_Click"/>
        <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click"/>
    </div>
    </form>
</body>
</html>
