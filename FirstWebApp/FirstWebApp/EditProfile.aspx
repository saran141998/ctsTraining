<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditProfile.aspx.cs" Inherits="FirstWebApp.EditProfile" %>

<asp:Content ID="signupContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label ID="idLabel" runat="server">ID</asp:Label>  
          <asp:TextBox id="Id" runat="server" placeholder="Enter Id" CssClass="form-control"></asp:TextBox>
	<asp:Label ID="nameLabel" runat="server">Name</asp:Label>  
          <asp:TextBox id="NameId" runat="server" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
	<asp:Button CssClass="btn btn-primary" ID="updteButton" runat="server"  Text="Update" OnClick="ButtonId_Click" />
</asp:Content>

