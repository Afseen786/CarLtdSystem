<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CustomerStyleSheet.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 137px;
            height: 97px;
            margin-left: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 480px">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" Text="CarLtd"></asp:Label>
        </div>
        <br />
        <div style="margin-left: 440px">
        <img alt="" class="auto-style1" src="Images/logo.PNG" /></div>
        <br />
        <asp:ListBox ID="lstCustomers" runat="server" Height="238px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged" style="margin-left: 279px; margin-top: 17px" Width="455px" Font-Size="Small"></asp:ListBox>
        <br />
        <br />
        <div style="margin-left: 280px">
            <asp:Label ID="lblError" runat="server" ForeColor="White"></asp:Label>
        </div>
        <br />
        <div style="margin-left: 280px">
            <asp:Label ID="Label1" runat="server" Text="Please Enter a Post Code" ForeColor="White"></asp:Label>
        </div>
        <asp:TextBox ID="txtPostCode" runat="server" Width="159px" Height="16px" style="margin-left: 276px; margin-top: 0px" Font-Size="Small"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="110px" OnClick="btnApply_Click" style="margin-left: 278px" Height="31px" Font-Size="Medium" />
        <asp:Button ID="btnDisplayAll" runat="server" style="margin-left: 29px" Text="Display All" Width="115px" OnClick="btnDisplayAll_Click" Height="30px" Font-Size="Medium" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="100px" OnClick="btnAdd_Click" style="margin-left: 279px" Height="32px" Font-Size="Medium" />
        <asp:Button ID="btnEdit" runat="server" style="margin-left: 23px" Text="Edit" Width="106px" OnClick="btnEdit_Click" Height="31px" Font-Size="Medium" />
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 19px" Text="Delete" Width="98px" OnClick="btnDelete_Click" Height="31px" Font-Size="Medium" />
    </form>
</body>
</html>
