import React, { useState } from "react";
import Parent from "./components/Parent";

 
// Step-1
export const userContext  = React.createContext(null);	 


function App(){

  // Step-2:
   let [userObj, setUserObj] = useState({ name : "Scott", age : 25, email : "scott@gmail.com"});
   
     
  return (
    <>
      <userContext.Provider   value={userObj}>
        <Parent />
      </userContext.Provider>
             
    </>
  );
}
 

export default App;