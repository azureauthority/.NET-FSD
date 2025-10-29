import Greeting from "./Greeting";

 

function App(){

 let user1 = "Ravi";
 let user2 = "Ragu";

 let usersArray = ["Smith", "Sam", "Sandy"];

 let resultsArray = usersArray.map((item, index) =>  
    <Greeting uname={item} key={index} />
 );
   
  return (
    <>
    <h3>Working with Props in React</h3>
    <hr/>

    <Greeting  uname="Narasimha" />
    <Greeting  uname="Scott" />

    <hr/>

    <Greeting  uname={user1} />
    <Greeting  uname={user2} />
    <hr/>
 
     {resultsArray}
    </>
  );
}
 

export default App;