<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SignupAndLogin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="jumbotron">
		<asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
	        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
	
			<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
	        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
		
	<asp:Button ID="Button1"  runat="server" Text="Button" CssClass="btn btn-primary" OnClick="Button1_Click"  />
	</div>
	
</asp:Content>
