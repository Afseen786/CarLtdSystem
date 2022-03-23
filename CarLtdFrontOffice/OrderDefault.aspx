<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDefault.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" Height="300px" style="margin-left: 200px" Width="400px"></asp:ListBox>
        </div>
        <p style="margin-left: 280px; margin-bottom: 1px">
            <asp:Label ID="lblOrderNo" runat="server" Text="Please enter a order number"></asp:Label>
        </p>
        <p style="margin-left: 280px">
            <asp:TextBox ID="txtBoxOrders" runat="server" Height="20px" style="margin-left: 0px; margin-top: 1px" Width="165px"></asp:TextBox>
        </p>
        <p style="margin-left: 280px">
            <asp:Button ID="btnApply" runat="server" style="margin-left: 0px" Text="Apply" Width="80px" />
            <asp:Button ID="btnDisplayAll" runat="server" style="margin-left: 10px" Text="Display All" Width="80px" />
        </p>
        <p style="margin-left: 280px">
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="margin-left: 10px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" style="margin-left: 10px" Text="Delete" OnClick="btnDelete_Click" />
        </p>
    </form>
</body>
</html>
