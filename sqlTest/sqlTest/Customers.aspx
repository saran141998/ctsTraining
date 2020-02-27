<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="sqlTest.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="jumbotron">
		<asp:TextBox ID="searchId" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
		<asp:GridView ID="cusData" runat="server">
			<HeaderStyle BackColor="White" />
		</asp:GridView>

	</div>
</asp:Content>
