<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uebersicht.aspx.cs" Inherits="WebShop.View.Uebersicht" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 id="Titel" runat="server">Welcome to the Web Shop </h1>

        <asp:Button ID="ZumWarenkorbButton" runat="server" Text="Warenkorb" OnClick="ZumWarenkorbButton_Click"/>
        <p id="TotalWarenkorbLabel" runat="server">0</p>

        <asp:GridView ID="GridViewProdukte" runat="server" AutoGenerateColumns="false" OnRowCommand="GridViewProdukte_RowCommand" DataKeyNames="ProduktId">
            <Columns>
                <asp:BoundField ItemStyle-Width="150px" DataField="ProduktId" HeaderText="Produkt Id"/>
                <asp:BoundField ItemStyle-Width="150px" DataField="Produktname" HeaderText="Produktname"/>
                <asp:BoundField ItemStyle-Width="150px" DataField="Produktbeschreibung" HeaderText="Produktbeschreibung"/>
                 
                <asp:TemplateField ShowHeader="False">
                      <ItemTemplate>
                          <asp:Button ID="Button2" runat="server" CausesValidation="false" CommandName="SeeDetails" Text="Details" CommandArgument='<%# Eval("ProduktId") %>' UseSubmitBehavior="false"/>
                      </ItemTemplate>
                  </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
