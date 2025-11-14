using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;
using WebApplication10.Dtos;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public static List<Employee> empList { get; set; }

        static EmployeesController() { 
        
            empList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 }
            };
        }



        [HttpGet]
        public ActionResult< List<Employee> > GetAll()
        { 
            return Ok(empList);
        }



	[HttpPost]
        public IActionResult Login(UserLoginDto dtoObj)
        {

             var users = new List<User>
{
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Password = "Password123!",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Password = "SecurePass456!",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    Password = "MyPass789!",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Johnson",
                    Email = "emily.johnson@example.com",
                    Password = "EmilyPass321!",
                    CreatedAt = DateTime.Now
                },
                new User
                {
                    Id = 5,
                    FirstName = "David",
                    LastName = "Wilson",
                    Email = "david.wilson@example.com",
                    Password = "DavidPass654!",
                    CreatedAt = DateTime.Now
                }
        };


            User obj = users.FirstOrDefault(item => item.Email == dtoObj.Email && item.Password == dtoObj.Password);
			
			// EF  Version
			//   User obj = _context.Users.FirstOrDefault(item => item.Email == dtoObj.Email && item.Password == dtoObj.Password);



            if ( obj != null )
            {
                 return Ok(new { Message =  "Welcome to My Web Application"});  
            }
            else
            {
               return NotFound(new { Message =  "Invalid User Credentials"});  
            } 
	}
       
    }
}
