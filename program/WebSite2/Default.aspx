<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
          &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    </h2>
    <p>
        <asp:Label ID="Label2" runat="server" Text="NAME" Font-Bold="True"></asp:Label>
&nbsp;

        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtname" runat="server" style="margin-left: 0px"></asp:TextBox>
    </p>
    <p>
       
        P<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ADD" />
        <asp:Label ID="Label3" runat="server" Font-Bold="True"></asp:Label>
    </p>
    <p>
        
    </p>
</asp:Content>
