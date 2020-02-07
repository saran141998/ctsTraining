<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebFormControls.aspx.cs" Inherits="Controls.WebFormControls" %>

<asp:Content ID="webControls" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">
		<asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
		<br />
		<asp:TextBox ID="txtName" placeholder="Enter Name" runat="server"></asp:TextBox>
		<br />
		<asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
		<br />
		<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
		<br />
		<asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
		<br />
		<asp:RadioButtonList ID="RadioButtonList1" runat="server" >
			<asp:ListItem>Male</asp:ListItem>
			<asp:ListItem>Female</asp:ListItem>
			<asp:ListItem>Gender 3</asp:ListItem>
		</asp:RadioButtonList>
		
		<asp:Label ID="Label4" runat="server" Text="Choose your Hobbies"></asp:Label>
		<br />
		<asp:CheckBoxList ID="CheckBoxList1" runat="server">
			<asp:ListItem>Singing</asp:ListItem>
			<asp:ListItem>Dancing</asp:ListItem>
			<asp:ListItem>Playing</asp:ListItem>
		</asp:CheckBoxList>
		<br />
		<asp:Label ID="Label5" runat="server" Text="Choose State"></asp:Label>
		<br />
		<asp:DropDownList ID="stateId" runat="server" Height="16px" OnSelectedIndexChanged="stateId_SelectedIndexChanged" Width="101px">
			<asp:ListItem>AP</asp:ListItem>
			<asp:ListItem>TN</asp:ListItem>
			<asp:ListItem>MP</asp:ListItem>
			<asp:ListItem>UP</asp:ListItem>
		</asp:DropDownList>
		<br />
		<br/>
		<asp:Button ID="Button1" runat="server" Text="Button" Height="29px" OnClick="Button1_Click" Width="63px" />
	</div>
	<div class="jumbotron">

		

	</div>
</asp:Content>