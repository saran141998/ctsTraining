<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ImageUpload.aspx.cs" Inherits="GalleryApp.ImageUpload" %>

<asp:Content ID="imageContent" ContentPlaceHolderID="MainContent" runat="server" >

	<div class="jumbotron">
		<asp:Label ID="Label1" runat="server" Text="Label" ></asp:Label>
		<asp:FileUpload ID="FileUpload1" CssClass="btn btn-primary" runat="server" />
		<br />
		<br />
		<asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Upload" OnClick="Button1_Click" />
		<br />
		<br />
		<asp:DataList ID="DataList1" runat="server" RepeatColumns="3">

			<ItemTemplate>
				<asp:Image ID="Image1"
					ImageUrl='<%#Eval("Name","~/Resources/{0}") %>'
					width="350px" Height="350px" runat="server" />
				<br />
				<%# Eval("Name") %>
			</ItemTemplate>

		</asp:DataList>


	</div>
	
</asp:Content>

