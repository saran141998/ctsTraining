var errors = {
    passError: "Password must be same",
    lenError: "Password must be not less than 8 characters"
};

validateForm = () => {
    var nameReg = /^[A-Za-z]+$/;

    var nam = document.getElementById('UsernameId').value;
    console.log(nam);
   
    if (!nameReg.test(nam)) {
        alert("Name must contain only letters");
        return false;
    }
    var pass = document.forms["myForm"]["psw"].value;

    var passRepeat = document.forms["myForm"]["psw-repeat"].value;
    // if(pass.length<8){
    //     alert(errors.lenError);
    // }
    if (pass != passRepeat) {
        alert(errors.passError);
        return false;
    }
};
res = () => {
    document.forms["myForm"].reset();
};
togglePass = () => {
    var x = document.getElementById("psw");
    x.classList.toggle("fa-eye-slash");
    var y = document.getElementById("password-field");
    if (y.type === "password") {
        y.type = "text";
    } else {
        y.type = "password";
    }
};
