<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/Master2.css" rel="stylesheet" />
    <link href="CSS/Login.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" Runat="Server">
    <div id="container">
    <h2 id="hLogin">Login Here ..!!</h2>
    
       
            <label for="username">Username:</label>
            <asp:TextBox ID="usrname" runat="server"></asp:TextBox>
        <%--    <input type="text" id="username" name="username"/>--%>
            <label for="password">Password:</label>
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <%--<input type="password" id="password" name="password"/>--%>
            <div id="lower">
                <center>
                <table>
                    <tr>
                        <td><input type="checkbox"/><label class="check" for="checkbox" >Keep me logged in</label></td>
                        <td><asp:Button ID="log" runat="server" Text="Login" OnClick="log_Click"/></td>
                    </tr>
                    <tr>
                        <td>
                            <h6>if you dont have an Login</h6>
                        </td>
                        <td><asp:Button ID="sign" runat="server" Text="Sign-up" OnClick="sign_Click" /></td>
                    </tr>
                </table>
                </center>
            </div><!--/ lower-->
    </div><!--/ container-->
</asp:Content>