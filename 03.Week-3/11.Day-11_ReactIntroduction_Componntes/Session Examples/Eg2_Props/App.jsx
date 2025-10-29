import CityList from "./CityList";
 
function App(){
  let arr =  ['Hyd', 'Mumbai', 'Delhi', 'Goa'];
     
  return (
    <>
    <h3>Working with Props in React</h3>
    <hr/>
    <CityList cities={ arr  }  />  
    </>
  );
}
 

export default App;