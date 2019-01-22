<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WarenkorbView.aspx.cs" Inherits="WebShop.View.WarenkorbView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Warenkorb</h1>
        <br />
         <asp:GridView ID="GridViewWarenkorb" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField ItemStyle-Width="150px" DataField="Id" HeaderText="Id"/>
                <asp:TemplateField ItemStyle-Width="150px" HeaderText="Id">
                    <itemtemplate>
                        <p><%#DataBinder.Eval(Container.DataItem, "Produkt.Produktname")%></p>
                    </itemtemplate>
                </asp:TemplateField>
               <asp:TemplateField ItemStyle-Width="150px" HeaderText="Id">
                    <itemtemplate>
                        <p><%#DataBinder.Eval(Container.DataItem, "Produkt.Preis")%></p>
                    </itemtemplate>
                </asp:TemplateField>     
            </Columns>
        </asp:GridView>
        <br />
        <p id="TotalWarenkorbLabel" runat="server">0</p>
        <asp:Button ID="ZurueckButton" runat="server" Text="Zurueck" OnClick="ZurueckButton_Click"/>
    </div>
    </form>
</body>
</html>
