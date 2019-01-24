<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebShop.View.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Details</title>
    <link rel="stylesheet" href="/Style/MKWebShopStyle.css" />
    <meta charset="utf-8" />
</head>
<body>
    <div class="Header">
        <h1 class="TitleLabel">MK WebShop</h1>
    </div>

    <form id="form1" runat="server">
        <h1 class="UebertitelStyle" runat="server">Details zum Produkt: </h1>
        <div class="DetailContainer">
            <p class="DetailUebertitelLabels">Produktname: </p>
            <p id="ProduktnameLabel" runat="server" class="DetailLabels"></p>

            <p class="DetailUebertitelLabels">Produktbeschreibung: </p>
            <p id="ProduktbeschreibungLabel" runat="server" class="DetailLabels"></p>

            <p class="DetailUebertitelLabels">Preis: </p>
            <p id="PreisLabel" runat="server" class="DetailLabels"></p>
        </div>
        <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click" CssClass="ZurueckDetailButtonStyle" />
        <asp:Button ID="IndenWarenkorbButton" runat="server" Text="In den Warenkorb" OnClick="IndenWarenkorbButton_Click" CssClass="InDenWarenkorbButton" />
    </form>
    <div class="Footer" />
</body>
</html>
