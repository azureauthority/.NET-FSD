using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.DTOs;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 },
                 new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 },
                 new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 }
            };

            return View(empList);
        }


        [HttpGet]

        public IActionResult Login()
        {
            return View();
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



            if ( obj != null )
            {
                ViewBag.Message = "Welcome to My Web Application";
            }
            else
            {
                ViewBag.Message = "Invalid User Credentails";
            }
            
            return View();
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
