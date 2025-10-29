import { useState } from "react";



function RegistrationForm() {

    const [uname, setUname] = useState("");
    const [password, setPassword] = useState("");
    const [retypePassword, setRetypePassword] = useState("");
    const [email, setEmail] = useState("");   

    const [result, setResult] = useState("");   

     const [unameError, setUnameError] = useState("");  
     const [passwordError, setPasswordError] = useState("");  
     const [retypePasswordError, setRetypePasswordError] = useState("");  
     const [emailError, setEmailError] = useState("");  

    

    function handleSubmit(e)   {   

        e.preventDefault();  

        let isValid = true;

        setUnameError("");
        setPasswordError("");
        setRetypePasswordError("");
        setEmailError("");


        if(!uname)  {
                setUnameError("User Name is required");
                isValid = false;
        }

        if(!password) {
            setPasswordError("Password is required");
            isValid = false;
        }  

        if(password != retypePassword ) 
        {
            isValid = false;
            setRetypePasswordError("Password and rettype password should be same..!");
        } 
         
        
       

        const validEmailRegex = RegExp(/^(([^<>()\[\]\.,;:\s@\"]+(\.[^<>()\[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i);
        
        if( validEmailRegex.test(email) == false)
        {
            setEmailError('Email is not valid!');
            isValid = false;
        }
 
 

        
						
		if(isValid == false) return; 
        				
       
        // Make an ajax call to send data to server
        setResult("Customer details are valid. We can send data to server.");       
        


    }


  return (<>

            <h3>Performing form validations in React JS</h3>
            <hr />

              <form  onSubmit={handleSubmit}  noValidate>     
                <fieldset>
                    <legend>Customer Registration Form</legend>

                    User Name  :  
                    <input type="text" value={uname} onChange={(e) => setUname(e.target.value)}  />
                    <span style={{color:"red"}}>{unameError}</span>
                    <br/><br/>

                    Password  :  
                    <input type="password" value={password}  onChange={(e) => setPassword(e.target.value)}  />
                   <span style={{color:"red"}}>{passwordError}</span>
                    <br/><br/>


                    Retype Password  :  
                    <input type="password" value={retypePassword}  onChange={(e) => setRetypePassword(e.target.value)}  />
                    <span style={{color:"red"}}>{retypePasswordError}</span>
                    <br/><br/>

                    E-mail Id:
                    <input type="email" value={email}   onChange={ (e) => setEmail(e.target.value)}  />
                    <span style={{color:"red"}}>{emailError}</span>
                    <br/><br/>

                      <input type="submit" value="Register" />
                </fieldset>
            </form>

            <div>
                <h3>{result}</h3>
            </div>
  </>);
}

export default RegistrationForm;