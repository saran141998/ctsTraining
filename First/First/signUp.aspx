<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="First.signUp" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <title>Document</title>
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
  <link rel="stylesheet" href="StyleSheet1.css" />

  <script>
      validate = () => {
          var nameReg = /^[A-Za-z]+$/;
          var name = document.getElementById("UsernameId").value;
          if (!nameReg.test(name)) {
              alert("Name must contain only letters");
              return false;
          }
          else {
              console.log(name);
          }
          var pass = document.getElementById("passwordId").value;
          var passRepeat = document.getElementById("passwordrepeat").value;
          if (pass != passRepeat) {
              alert("Password and confirm password must be same");
              return false;
          }
      }
      togglePass = () => {
          var x = document.getElementById("psw");
          x.classList.toggle("fa-eye-slash");
          var y = document.getElementById("passwordId");
          console.log(y.TextMode);
          if (y.type === "password") {
              y.type = "text";
          } else {
              y.type = "password";
          }
      };
  </script>
</head>
<body class="preload">
  <div>
    <form class="modal-content" name="myForm" method="POST" onsubmit="return validate()" runat="server">
      <div class="container">
           
         

           <asp:Label ID="Label1" runat="server">Name</asp:Label>  
          <asp:TextBox id="UsernameId" runat="server"></asp:TextBox>

           <asp:TextBox ID="EmaiID" runat="server"></asp:TextBox>
           <asp:TextBox id="passwordId" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
          <asp:TextBox id="passwordrepeat" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
          <asp:span id="psw"
          class="fa fa-eye field-icon"  onclick="togglePass()" aria-hidden="true"></asp:span>
       
        <p>
          By creating an account you agree to our
          <a href="#" style="color:dodgerblue">Terms & Privacy</a>.
        </p>
        <asp:Button CssClass="btn signupbtn" ID="ButtonId" runat="server" OnClick="SignUp_Click" Text="Submit" />
      </div>
    </form>
  </div>
</body>
</html>