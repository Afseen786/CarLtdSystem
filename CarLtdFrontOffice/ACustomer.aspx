<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 11px"></asp:TextBox>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 5px"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="LastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="margin-left: 5px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 6px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPostCode" runat="server" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="margin-left: 9px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPurchaseDate" runat="server" Text="PurchaseDate"></asp:Label>
        <asp:TextBox ID="txtPurchaseDate" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="53px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 31px" Text="Cancel" />
    </form>
</body>
</html>
