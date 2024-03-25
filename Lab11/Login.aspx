<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lab11.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<style>
    table {
      border-collapse: separate; 
      border-spacing: 10px;
    }
</style>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <table>
            <tr>
                <td>Username: (*)</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="Username is required" ControlToValidate="txtUsername" ForeColor="Red" runat="server">Username is required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password: (*)</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="Password is required" ControlToValidate="txtPassword" ForeColor="Red" runat="server">Password is required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
            </tr>
        </table>
        <asp:ValidationSummary ID="validationsummary" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
