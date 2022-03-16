<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CustomerStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 11px"></asp:TextBox>
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 308px" Text="Find" Width="103px" Font-Size="Medium" />
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="FirstName" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 5px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="LastName" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="margin-left: 5px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" Text="DateOfBirth" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="margin-left: 12px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="margin-left: 6px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPostCode" runat="server" Text="PostCode" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="margin-left: 9px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkactive" runat="server" Text="Active" Font-Size="Large" ForeColor="White" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="74px" Font-Size="Medium" Height="32px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 31px" Text="Cancel" OnClick="btnCancel_Click" Font-Size="Medium" Height="30px" Width="83px" />
    </form>
</body>
</html>
