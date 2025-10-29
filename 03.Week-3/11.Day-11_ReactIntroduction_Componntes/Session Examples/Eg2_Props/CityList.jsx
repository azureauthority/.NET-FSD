
function   CityList(  { cities }  )
{ 	
    return (
    <>
          <ul>
              { cities.map((item, index) => <li key={index}>{item}</li>) }
        </ul>
    </>);
}


export default CityList;
