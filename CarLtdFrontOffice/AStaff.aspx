<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BorderColor="Red" BorderStyle="Solid" Height="472px" style="z-index: -1" Width="1048px">
            <asp:Label ID="lblLastName" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 398px; top: 205px; position: absolute" Text="Last Name"></asp:Label>
            <asp:Label ID="lblPhoneNo" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 398px; top: 270px; position: absolute" Text="PhoneNo"></asp:Label>
            <asp:Label ID="lblDepartment" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 396px; top: 337px; position: absolute; right: 589px" Text="Department"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 398px; top: 407px; position: absolute" Text="Date Added"></asp:Label>
            <asp:Label ID="lblStaffID" runat="server" Font-Names="Franklin Gothic Demi" style="position: absolute; z-index: 2; left: 80px; top: 291px" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 3; left: 158px; top: 291px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 2; left: 535px; top: 142px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 2; left: 535px; top: 201px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 2; left: 533px; top: 268px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 2; left: 533px; top: 335px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 2; left: 533px; top: 405px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="Active" runat="server" Font-Names="Franklin Gothic Demi" style="position: absolute; z-index: 2; left: 393px; top: 77px" Text="Active" />
            <asp:Label ID="lblError" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 26px; top: 480px; position: absolute"></asp:Label>
            <asp:Button ID="btnOk" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 460px; top: 461px; position: absolute; width: 69px; height: 27px;" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 567px; top: 460px; position: absolute; width: 69px" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 3; left: 182px; top: 333px; position: absolute" Text="Find" Width="69px" />
            <asp:Label ID="lblFirstName" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 2; left: 399px; top: 140px; position: absolute" Text="First Name"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
