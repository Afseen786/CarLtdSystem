<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Car.aspx.cs" Inherits="Car" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label2" runat="server" Text="VehicleNo"></asp:Label></td>
                    <td><asp:TextBox ID="txt_VehicleNo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label3" runat="server" Text="Model"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Model" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label4" runat="server" Text="EngineType"></asp:Label></td>
                    <td><asp:TextBox ID="txt_EngineType" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label5" runat="server" Text="EngineCC"></asp:Label></td>
                    <td><asp:TextBox ID="txt_EngineCC" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2"><asp:Label ID="Label6" runat="server" Text="Color"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Color" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
