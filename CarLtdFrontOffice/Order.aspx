<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="margin-left: 39px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOrderName" runat="server" Text="OrderName"></asp:Label>
        <asp:TextBox ID="txtOrderName" runat="server" style="margin-left: 23px; margin-bottom: 0px;"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOrderStatus" runat="server" Text="OrderStatus"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" style="margin-left: 22px; margin-bottom: 0px;"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 29px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblBillingAddress" runat="server" Text="Billing Address"></asp:Label>
        <asp:TextBox ID="txtBillingAddress" runat="server" Height="50px" style="margin-left: 3px" Width="160px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="Active" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnFindOrders" runat="server" OnClick="btnFindOrders_Click" Text="Find Orders" Width="90px" />
        <br />
    </form>
</body>
</html>
