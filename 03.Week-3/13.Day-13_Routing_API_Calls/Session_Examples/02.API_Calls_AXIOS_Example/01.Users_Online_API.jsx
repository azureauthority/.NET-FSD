import axios from "axios";
import React, { useEffect, useState } from "react";

function Users() {

  const [users, setUsers] = useState([]);
 

  useEffect(() => {
     
   	let  url = "https://jsonplaceholder.typicode.com/users";

     axios.get(url).then( (resData) => 
    {
       setUsers(resData.data);
    });
      
  }, []);

  
  let resultsArray =  users.map((user) => (
            <tr key={user.id}>
              <td>{user.id}</td>
              <td>{user.name}</td> 
              <td>{user.email}</td> 
            </tr>
          ));
 
  return (
    <div>
      <h1>User List</h1>
      <table border="1" cellPadding="6" cellSpacing="0">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th> 
            <th>Email</th> 
          </tr>
        </thead>
        <tbody>
         {resultsArray}
        </tbody>
      </table>
    </div>
  );
}


export default Users;