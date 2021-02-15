<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <!-- Liabraries are added here -->
    <link href="CSS/YouthMaster.css" rel="stylesheet" />
    <link href="CSS/Profile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentLeft" Runat="Server">
    <center>
        <br />
        <br />
        <h2><asp:Label ID="usrName" runat="server" Text="Label" CssClass="lblUName"></asp:Label></h2>
        <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" CssClass="myButton"></asp:Button>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="Edit Profile" OnClick="btnEdit_Click" CssClass="myButton"></asp:Button>
        
        &nbsp;
        
        <br />
        <br />
        <asp:Panel ID="editPanel" runat="server" Visible="False">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" CssClass="myButton"></asp:Button>
                    </td>
                    <td>
                        <asp:Button ID="btnCancle" runat="server" Text="Cancle" OnClick="btnCancle_Click" CssClass="myButton"></asp:Button>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </center>
</asp:Content>

<%-- Main Content --%>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentMain" Runat="Server">
    <center>

        <br />
        <h1 id="hConfess">
            <b>Confesion are here......</b>
        </h1>
                        <asp:Button ID="btnReTweet" runat="server" Text="See Your Re-Tweets" CssClass="myButton" OnClick="btnReTweet_Click"></asp:Button>
        <br />
        <br />
        <br />
        <asp:GridView ID="gvConfess" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </center>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentRight" Runat="Server">
                    <br />
                    <center>
                        <h2 id="hConfess">
                            Recent Users...
                        </h2>
                        <br />
                        <asp:GridView ID="gvUserList" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                    </center>

</asp:Content>

