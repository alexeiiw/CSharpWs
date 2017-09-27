<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFIngreso.aspx.cs" Inherits="HolaMundoWs2.WFIngreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><h1><asp:Label ID="LblTitulo" runat="server"></asp:Label></h1></tr>

                <tr>
                    <td><asp:Label ID="Label1" runat="server"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" /></td>
                    <td><asp:Label ID="LblResultado" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
