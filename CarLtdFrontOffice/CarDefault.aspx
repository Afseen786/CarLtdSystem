<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        <asp:Label ID="lbl_Error" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ListBox ID="lstCars" runat="server" Height="149px" Width="303px"></asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btn_add" runat="server" Text="ADD" /><br />
        <asp:Button ID="btn_update" runat="server" Text="UPDATE" /><br />
        <asp:Button ID="btn_delete" runat="server" Text="DELETE" />
        
    </form>
</body>
</html>
