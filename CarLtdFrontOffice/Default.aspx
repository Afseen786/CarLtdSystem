<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <br />
        <asp:ListBox ID="lstCustomers" runat="server" Height="196px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged" style="margin-left: 3px; margin-top: 17px" Width="369px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please Enter a Post Code"></asp:Label>
        <br />
        <asp:TextBox ID="txtPostCode" runat="server" Width="158px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="110px" />
        <asp:Button ID="btnDisplayAll" runat="server" style="margin-left: 13px" Text="Display All" Width="98px" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="55px" />
        <asp:Button ID="btnEdit" runat="server" style="margin-left: 12px" Text="Edit" Width="58px" />
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 12px" Text="Delete" Width="55px" />
    </form>
</body>
</html>
