<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WarenkorbView.aspx.cs" Inherits="WebShop.View.WarenkorbView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Warenkorb</title>
    <link rel="stylesheet" href="/Style/MKWebShopStyle.css" />
    <meta charset="utf-8" />
</head>
<body>
    <div class="Header">
        <h1 class="TitleLabel">MK WebShop</h1>
    </div>
    <h1 runat="server" class="UebertitelStyle">Warenkorb </h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:GridView ID="GridViewWarenkorb" runat="server" AutoGenerateColumns="false" CssClass="GridViewStyle" RowStyle-CssClass="GridViewRowStyle" HeaderStyle-CssClass="GridViewHeader">
                <Columns>
                    <asp:TemplateField ItemStyle-Width="150px" HeaderText="Produktname">
                        <ItemTemplate>
                            <p><%#DataBinder.Eval(Container.DataItem, "Produkt.Produktname")%></p>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-Width="150px" HeaderText="Preis">
                        <ItemTemplate>
                            <p><%#DataBinder.Eval(Container.DataItem, "Produkt.Preis")%></p>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <p id="TotalWarenkorbLabel" runat="server" class="TotalWarenkorbLabel">0</p>
            <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click" CssClass="WarenkorbZurueckButton" />
        </div>
    </form>
    <div class="Footer" />
</body>
</html>
