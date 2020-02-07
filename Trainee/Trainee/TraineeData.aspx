<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/Site.Master" CodeBehind="TraineeData.aspx.cs" Inherits="Trainee.TraineeData" %>

<asp:Content ID="traineeData" ContentPlaceHolderID="MainContent" runat="server">

	<div class="jumbotron">
		
		<asp:GridView ID="trainerDataGrid" runat="server">
			<HeaderStyle BackColor="White" />
		</asp:GridView>

	</div>

	 <a href="TraineeSearch.aspx" class="btn btn-primary">Trainee Search</a>
	
	 <a href="InsertTrainee.aspx" class="btn btn-primary">Add Trainee</a>
	 
	<a href="EditTrainee.aspx" class="btn btn-primary">Edit Trainee</a>

</asp:Content>
