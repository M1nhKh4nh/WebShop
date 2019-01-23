<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uebersicht.aspx.cs" Inherits="WebShop.View.Uebersicht" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Style/MKWebShopStyle.css"/>
    <meta charset="ISO-8859-1"/> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="Header">
            <h1 class="TitleLabel">MK WebShop</h1>
        </div>
        
        <div class="WarenkorbContainer">
            <asp:Button ID="ZumWarenkorbButton" runat="server" Text="Warenkorb" OnClick="ZumWarenkorbButton_Click" CssClass="WarenkorbButton"/>
            <p id="TotalWarenkorbLabel" runat="server" class="TotalWarenkorbLabelOverview">0</p>
        </div>
    </div>
    
     <div>
        <h1 id="Titel" runat="server">Welcome to the Web Shop </h1>
        <h2 class="UebertitelOverviewStyle" runat="server">Übersicht der Produkte </h2>

       
        <asp:GridView ID="GridViewProdukte" runat="server" AutoGenerateColumns="false" OnRowCommand="GridViewProdukte_RowCommand" DataKeyNames="ProduktId" CssClass="GridViewOverviewStyle" RowStyle-CssClass="GridViewRowStyle" HeaderStyle-CssClass="GridViewHeader">
            <Columns>
                <asp:BoundField ItemStyle-Width="150px" DataField="Produktname" HeaderText="Produktname" />
                <asp:BoundField ItemStyle-Width="150px" DataField="Produktbeschreibung" HeaderText="Produktbeschreibung"/>
                <asp:BoundField ItemStyle-Width="150px" DataField="Preis" HeaderText="Preis"/>            
                <asp:TemplateField ShowHeader="False" ItemStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Button ID="Button2" runat="server" CausesValidation="false" CommandName="SeeDetails" Text="Details" CommandArgument='<%# Eval("ProduktId") %>' UseSubmitBehavior="false" CssClass="DetailsButtonStyle"/>
                      </ItemTemplate>
                  </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
    <div class="Footer"/>
</body>
</html>
