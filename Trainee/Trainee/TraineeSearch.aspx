<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TraineeSearch.aspx.cs" Inherits="Trainee.TraineeSearch" %>


<asp:Content ID="search" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">

		<asp:TextBox ID="searchId" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

	<asp:GridView ID="searchGrid" runat="server"></asp:GridView>
	</div>
	
</asp:Content>
