<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SignUp.aspx.cs" Inherits="FirstWebApp.SignUp" %>

<asp:Content ID="signupContent" ContentPlaceHolderID="MainContent" runat="server">

	<div class="container container-table">
		
          <asp:Label ID="Label1" runat="server">Name</asp:Label>  
          <asp:TextBox id="UsernameId" runat="server" placeholder="Enter Name" CssClass="form-control"></asp:TextBox>
	      
	<asp:Label ID="Label2" runat="server">EmailId</asp:Label>  
           <asp:TextBox ID="EmaiID" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
    <asp:Label ID="Label3" runat="server">Password</asp:Label>  
	<asp:TextBox id="passwordId" runat="server" placeholder="Password" TextMode="Password" CssClass="form-control"></asp:TextBox>

	<asp:Label ID="Label4" runat="server">ConfirmPassword</asp:Label>  
          <asp:TextBox id="passwordrepeat" runat="server" placeholder="Confirm Password" TextMode="Password" CssClass="form-control"></asp:TextBox>
	<asp:Button CssClass="btn btn-primary" ID="ButtonId" runat="server"  Text="Submit" OnClick="ButtonId_Click" />

	</div>
</asp:Content>
