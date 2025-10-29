import { useState } from "react";

function Login(){
    const [uname, setUname] = useState("");
    const [password, setPassword] = useState("");
    const [result, setResult] = useState("");
    const [unameError, setUnameError] = useState("");
    const [passwordError, setPasswordError] = useState("");

    function loginButtonClick()
    {

        // Step-1:  Clear messages 
        let valid = true;
        setUnameError("");
        setPasswordError("");
        setResult("");	


        // Step-2:   Perform Validations 
        if (uname == "") {
		        setUnameError("Username is required.");
		        valid = false;
        }
        else if (uname.length < 3) 
        {
            setUnameError("At least 3 characters required.");
            valid = false;
        }


         if (!password) {
                setPasswordError("Password is required.");
                valid = false;
        } 
        else if (password.length < 4) {
                setPasswordError("At least 4 characters required.");
                valid = false;
        }


        // Step-3:   Return if validation fails 
        if(valid == false ) return;


        // Step-4:   Login Logic 
        if(uname == "admin" && password == "admin123")
        {
            setResult("Welcome to Admin");
        }
        else
        {
             setResult("Invalid User Id or Password");
        }
    }


    return (
        <>
        <fieldset>
			<legend>Login Form</legend>		 

				<label for="username">User Nname:</label>
				<input type="text" onChange={(event) => setUname(event.target.value)}  />
				<span style={ {color:"red"} }>{unameError}</span>
                <br/> <br/>
			
				<label for="password">Password:</label>
				<input type="password" onChange={(event) => setPassword(event.target.value)}  />
				<span style={ {color:"red"} }>{passwordError}</span>
                <br/> <br/>

				<input type="button"  onClick={loginButtonClick}  value="Login"  /> 
                <p>{result}</p>
		</fieldset>
        
        </>
    );

}

export default Login;