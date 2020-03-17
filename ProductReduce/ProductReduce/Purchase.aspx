<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="ProductReduce.Purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">
	<asp:Label ID="Label1" runat="server" Text="Enter Product Id"></asp:Label>
	<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
	<asp:Label ID="Label2" runat="server" Text="Enter Quantity"></asp:Label>
	<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
		<asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Button" OnClick="Button1_Click" />
	</div>
	

</asp:Content>
