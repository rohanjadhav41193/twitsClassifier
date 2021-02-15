<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="confess.aspx.cs" Inherits="confess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!--Liabraries are added here-->
    <link href="CSS/confess.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentMain" Runat="Server">
    <center>
    <table>
        <tr>
            <td></td>
            <td><center>
                <h2 id="hConfessTag">
                    <b>Write the Confession...</b>
                </h2></center>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <br />
                <asp:TextBox id="txtConfessionArea" TextMode="multiline" Columns="61" Rows="5" runat="server" />

            </td>
            </tr>
            <%--<tr>
               <td></td>
               <td id="divConfessionType">
               <br />
                    <asp:Label ID="lblConfessionType" runat="server" Text="Enter name for Confession"></asp:Label>
                    <asp:TextBox ID="txtConfessionName" runat="server"></asp:TextBox>
               </td>
            </tr>--%>
            <tr>
               <td></td>
               <td id="divUserName">
                    <h3><asp:Label ID="lblUserName" runat="server" Text="Enter User Name"></asp:Label></h3>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
               </td>
            </tr>
           <tr>
            <td></td>
            <td>
                <div id="btnConfession">
                <br />
                        <asp:Button ID="cancel" runat="server" Text="CANCEL" CssClass="myButton" />
                        <asp:Button ID="topost" runat="server" Text="POST" CssClass="myButton" OnClick="topost_Click" />
                        
                </div>
            </td>
        </tr>
        
                <br />
                <br />
                <h2 id="lblConfessText"><asp:Label ID="lblReadConfess" runat="server" Visible="False"></asp:Label></h2>
            
        <%--<tr>
            <td></td>
            <td>
                <br />
                <br />
                <asp:Button CssClass="myButton" runat="server" Text="Like" ID="btnLike" Visible="False" OnClick="btnLike_Click"></asp:Button>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <br />
                <br />
                <asp:Button ID="btnDelete" CssClass="myButton" runat="server" Text="Delete" OnClick="btnDelete_Click"></asp:Button>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>

                <br />
                <br />
                <asp:Label ID="lblDelete" runat="server" Text="" Visible="True"></asp:Label>
            </td>
        </tr>--%>
    </table>
    </center>
</asp:Content>

