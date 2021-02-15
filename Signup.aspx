<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" Runat="Server">

    <!--liabraries are added here-->
    <link href="CSS/Sign-up.css" rel="stylesheet" />

    <h3>Join Youth Confessions Today..</h3>
    <div class="signup">
        <asp:TextBox ID="name" placeholder="Enter your Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="email" placeholder="Enter your Email"  runat="server"></asp:TextBox>
        <asp:TextBox ID="username" placeholder="Enter your UserName" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTweet" runat="server" Text="If Tweeter account then enter #tag" ForeColor="DarkBlue"></asp:Label>
        <asp:TextBox ID="password" placeholder="Enter your password" TextMode="Password"  runat="server"></asp:TextBox>
        <asp:Button ID="log" runat="server" Text="Sign-up" OnClick="log_Click" />
    </div> 


</asp:Content>

