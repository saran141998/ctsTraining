<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InsertTrainee.aspx.cs" Inherits="Trainee.InsertTrainee" %>

<asp:Content ID="insert" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">

		<asp:Label ID="Label1" runat="server" Text="Enter Trainer Data"></asp:Label>
		<br />
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ControlToValidate="txtName" ForeColor="Red" ValidationGroup="vg">Enter Name</asp:RequiredFieldValidator>
		<br />
        <asp:TextBox ID="txtName" placeholder="Enter Name" CssClass="form-control" runat="server" Width="391px"></asp:TextBox>

		<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Mail" ControlToValidate="txtEmail" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
		<br />

		<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Correct Mail" ControlToValidate="txtEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Enter Mail</asp:RegularExpressionValidator>
		<br />
        <asp:TextBox ID="txtEmail" placeholder="Enter Email" CssClass="form-control" runat="server" Width="391px"></asp:TextBox>

         
		<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mobile Number Required" ControlToValidate="txtMobile" ForeColor="Red" ValidationGroup="vg">Enter Mobile</asp:RequiredFieldValidator>
		<br />

         
        <asp:TextBox ID="txtMobile" placeholder="Enter Mobile" CssClass="form-control" runat="server" Width="391px"></asp:TextBox>
		<br />

         
		<asp:TextBox ID="trainerDob" placeholder="Enter Dob" CssClass="form-control" runat="server" ToolTip="Format shoulf be yyyy-mm-dd" Width="220px"></asp:TextBox>
		<br />

		<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Domain Required" ControlToValidate="txtDomain" ForeColor="Red" ValidationGroup="vg">Enter Domain</asp:RequiredFieldValidator>
		<br />

        <asp:TextBox ID="txtDomain" placeholder="Enter Domain" CssClass="form-control" runat="server" Width="391px"></asp:TextBox>
		<br />



		<asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="vg" OnClick="Button1_Click" />


		<br />



		<br />
	<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />

		<br />


		<br />
		<br />



	</div>
	
</asp:Content>
