 
import {  useEffect, useRef, useState } from "react";

function Counter() {

    let  [count,  setCount]  =  useState(0);
    let  [city,  setCity]  =  useState("");
    let  [num1,  setNum1]  =  useState(5);

     const inputResetRef = useRef(null);
    

     useEffect(() => {       
        //  add logic to connect server and get data : http calls 
         alert("Loading Users Data from API");
      }, [city]);  //  empty dependency array : useEffect will be called only once : on component load


   
    useEffect(() => 
    {
        if(count != 0)
        {
            inputResetRef.current.focus(); 
        }
              
    }, [count])
   

     function handleClick() {
        
        count = count + parseInt(num1);
        setCount(count  );    //  use set method to update the state variable
      
    }


    function handleResetClick()
    {
        setNum1(1);
        setCount(0);
    }

   
   
  return (
    <>  
         <h1>Demonstrate useEffect Hook in React </h1>
          <hr/>

        Enter number :  <input autoFocus  type="number" value={num1} onChange={(e) => setNum1(e.target.value)}  />
        <button onClick={handleClick}>Update Count</button>
        <hr/>
        <button ref={inputResetRef} onClick={handleResetClick}>Reset Counters</button>
        <h2>Counter Value: {count}</h2>   
        <hr/> 

        Choose City :  
        <select     onChange={(e) => setCity(e.target.value)}>
            <option>Hyd</option>
            <option>Mumbai</option>
            <option>Pune</option>
            <option>Goa</option>
        </select>

        <h3>Users Data display here</h3>

    </>
  );
}

export default Counter;