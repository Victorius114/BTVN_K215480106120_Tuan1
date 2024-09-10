<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="webABC._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GIẢI PHƯƠNG TRÌNH BẬC 2</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <h1>GIẢI PHƯƠNG TRÌNH BẬC 2</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Nhập a: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nhập b: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class>Nhập c: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Giải" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="ketqua" runat="server"></div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
