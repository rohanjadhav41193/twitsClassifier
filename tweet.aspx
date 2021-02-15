<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tweet.aspx.cs" Inherits="tweet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Liabraries are added here -->
    <link href="CSS/tweet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentMain" Runat="Server">
    <center>
        <br />
        <br />
        <h2 id="enjoy">
            Enjoy your TWEETS......
        </h2>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="ibiHashTag" runat="server" Text="Enter your Tweeter Hashtag" ForeColor="DarkBlue"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHashTag" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnImport" runat="server" Text="Import" CssClass="myButton" OnClick="btnImport_Click"></asp:Button>
                </td>
            </tr>
            <tr>
                <td><br /></td>
                <td></td>
            </tr>
        </table>
        <br />   
                <h2 id="enjoy"><asp:Label ID="lblDone" runat="server"></asp:Label></h2>
             
        
        
    </center>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentRight" Runat="Server">
</asp:Content>

