<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SignUp.aspx.cs" Inherits="Controls.SignUp" %>

<asp:Content ID="signupId" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name cannot be empty" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">Enter Name</asp:RequiredFieldValidator>
		<br />
		<asp:TextBox ID="TextBox1" runat="server" ToolTip="Enter Name"></asp:TextBox>
		<br />
		<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter Age Betwen 18 to 100" ControlToValidate="TextBox2" ValidationGroup="vg" ForeColor="Red" MaximumValue="99" MinimumValue="18" Type="Integer">Enter Age</asp:RangeValidator>
		<br />
		<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		<br />
		<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter the valid email Id" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Enter Email</asp:RegularExpressionValidator>
		<br />
		<asp:TextBox ID="TextBox3" placeholder="Email" runat="server"></asp:TextBox>
		<br />
		<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password and Confirm password should match" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ForeColor="Red" ValidationGroup="vg">Enter password</asp:CompareValidator>
		<br />
		<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
		<br />
		<asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
		<br />
		<asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg" />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="vg" />
	</div>
	


</asp:Content>
