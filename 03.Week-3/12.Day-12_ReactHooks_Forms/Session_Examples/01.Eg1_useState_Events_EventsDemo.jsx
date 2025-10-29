import { useState } from "react";
 
function EventsDemo(){

    const  [count,  setCount]  =  useState(1);	 
    const  [uname,  setUname]  =  useState("");	 
    const  [result,  setResult]  =  useState("");	    

    function handleClick(){
       setCount( count  + 1 );
    }

    function getMessageButtonClick(){

       setResult(`Hi ${uname},  Good morning...!`);
    }



     
  return (
    <>
        <h3>Event Handling in React</h3>
        <hr/>

        <h1>Count Value :  {count}</h1>
        <button  onClick={handleClick}>Update Count</button>
        <hr/>

        User Name :  <input type="text"  onChange={(event) => setUname(event.target.value)}  />
        <button  onClick={getMessageButtonClick}>Get Message</button>
        <p> {result} </p>        
    </>
  );
}
 

export default EventsDemo;