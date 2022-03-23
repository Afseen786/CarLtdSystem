<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Are you sure you want to delete this order?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="margin-left: 65px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
