<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chkActive" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 367px; top: 67px; position: absolute" Text="Active" />
        </div>
        <asp:Panel ID="Panel1" runat="server" BorderColor="Red" BorderStyle="Solid" Height="512px" Width="979px">
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 369px; top: 168px; position: absolute" Text="First Name" Font-Names="Franklin Gothic Demi"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 369px; top: 222px; position: absolute" Text="Last Name"></asp:Label>
            <asp:Label ID="lblPhoneNo" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 370px; top: 278px; position: absolute" Text="Phone No"></asp:Label>
            <asp:Label ID="lblDepartment" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 369px; top: 333px; position: absolute" Text="Department"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 369px; top: 391px; position: absolute" Text="Date Added"></asp:Label>
            <asp:Label ID="lblError" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 25px; top: 501px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnOK" runat="server" Font-Names="Franklin Gothic Demi" OnClick="btnOK_Click" style="z-index: 1; left: 408px; top: 466px; position: absolute" Text="OK" Width="88px" />
            <asp:Button ID="btnCancel" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 529px; top: 465px; position: absolute; width: 86px" Text="Cancel" />
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 523px; top: 166px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" style="position: absolute; z-index: 1; left: 523px; top: 217px"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 523px; top: 275px; position: absolute"></asp:TextBox>
            <asp:DropDownList ID="dropDepartment" runat="server" style="z-index: 1; left: 524px; top: 334px; position: absolute; height: 16px; width: 104px">
            </asp:DropDownList>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 520px; top: 388px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffID" runat="server" Font-Names="Franklin Gothic Demi" style="z-index: 1; left: 369px; top: 113px; position: absolute" Text="StaffID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 524px; top: 111px; position: absolute"></asp:TextBox>
        </asp:Panel>
    </form>
</body>
</html>
