import { useState } from "react";

function Login(){
    const [uname, setUname] = useState("");
    const [password, setPassword] = useState("");
    const [result, setResult] = useState("");

    function loginButtonClick()
    {
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
				<br/> <br/>
			
				<label for="password">Password:</label>
				<input type="password" onChange={(event) => setPassword(event.target.value)}  />
				<br/> <br/>

				<input type="button"  onClick={loginButtonClick}  value="Login"  /> 
                <p>{result}</p>
		</fieldset>
        
        </>
    );

}

export default Login;