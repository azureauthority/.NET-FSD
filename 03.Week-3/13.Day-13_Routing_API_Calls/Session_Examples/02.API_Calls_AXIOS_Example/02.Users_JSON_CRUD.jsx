import axios from "axios";
import React, { useEffect, useState } from "react";

function Users() {

  const [users, setUsers] = useState([]);

  const [name, setName]  = useState("");
  const [email, setEmail]  = useState("");

  const API_URL = "http://localhost:3000/users";
 

  useEffect(() => {
     
   getUsersData();
      
  }, []);


  function getUsersData(){	

    axios.get(API_URL).then( (resData) => 
    {
       setUsers(resData.data);
    });
  }


  function addUserClick(){
 
    let userObj = {name, email};

//    let userObj = {};
//    userObj.name = name ;
//    userObj.email = email;

    axios.post(API_URL, userObj).then( (resData) =>  
    {
        alert("New User details are added to server");
        getUsersData();

        setName("");
        setEmail("");
    });

  }

  function deleteUserClick(id)
  {
    if(  window.confirm("Do you want to delete?") == false )
    {
            return;
    }
        
    axios.delete(`${API_URL}/${id}`).then( (resData) => 
    {
         alert("Selected User details are deleted from server");
         getUsersData();
    });
      
  }


  function selectUserClick(id)
  {
    axios.get(`${API_URL}/${id}`).then( (resData) => 
    {
        setName(resData.data.name);
        setEmail(resData.data.email);
    });
  }
  
  let resultsArray =  users.map((user) => (
            <tr key={user.id}>
              <td>{user.id}</td>
              <td>{user.name}</td> 
              <td>{user.email}</td> 
              <td>
                <a href="javascript:void(0);" onClick={() => selectUserClick(user.id)}>Select</a> |
                <a href="javascript:void(0);" onClick={() => deleteUserClick(user.id)}>Delete</a> |
              </td>
            </tr>
          ));
 
  return (
    <div>
      <h3>CRUD Operations using AXIOS with JSON-Server</h3>
      <hr/>

      <input type="text" value={name} placeholder="Name" onChange={(e) =>  setName(e.target.value)}  />

      <input type="text"  value={email} placeholder="E-mail" onChange={(e) =>  setEmail(e.target.value)}  />
      
      <button onClick={addUserClick}>Add User</button>
      <hr/>

      <table border="1" cellPadding="6" cellSpacing="0">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th> 
            <th>Email</th> 
            <th></th>
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