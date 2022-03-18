<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CustomerStyleSheet.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 400px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this customer?" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="96px" OnClick="btnYes_Click" Font-Size="Medium" Height="38px" style="margin-left: 161px; margin-top: 0px" />
        <asp:Button ID="btnNo" runat="server" style="margin-left: 21px" Text="No" Width="105px" OnClick="btnNo_Click" Font-Size="Medium" Height="39px" />
        <br />
        <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
