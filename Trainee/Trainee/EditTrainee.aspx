<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditTrainee.aspx.cs" Inherits="Trainee.EditTrainee" %>

<asp:Content ID="edit" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">

		<asp:Label ID="Label1" runat="server" Text="Enter Trainer ID"></asp:Label>
		<br />
		<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="Label2" runat="server" Text="Enter Domain"></asp:Label>
		<br />
		<asp:TextBox ID="txtDomain" runat="server"></asp:TextBox>
		<br />
		<asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />

	</div>


</asp:Content>
