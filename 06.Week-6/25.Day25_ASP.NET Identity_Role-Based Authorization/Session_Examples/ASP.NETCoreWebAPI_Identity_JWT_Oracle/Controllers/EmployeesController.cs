using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class EmployeesController : ControllerBase
    {
        public static List<Employee> empList { get; set; }

        static EmployeesController() { 
        
            empList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 45000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 50000, Deptno = 20 },
                new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 85000, Deptno = 10 },
                new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 30000, Deptno = 20 }
            };
        }



        [HttpGet]
        public ActionResult< List<Employee> > GetAll()
        { 
            return Ok(empList);
        }


        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {  
            Employee obj = empList.FirstOrDefault( item => item.Id == id ) ;

            if (obj != null)
                return Ok(obj);
            else
                return NotFound(new { status = "Failed", message = "Requested employee id does not exists" });
        }

         
        
        [HttpGet("GetEmpsByDeptno/{deptno}")]
        public ActionResult<IEnumerable<Employee>> GetEmpsByDeptno(int deptno)
        {
            var  q1 =  from item in empList
                       where item.Deptno == deptno
                       select item;
           
            return Ok(q1);
        }

        [HttpGet("GetEmpsBySalary/{min}/{max}")]
        public ActionResult<IEnumerable<Employee>> GetEmpsBySalary(int min, int max)
        {
            var q1 = from item in empList
                     where item.Salary >= min && item.Salary <= max
                     select item;

            return Ok(q1);
        }


        [HttpPost]
        public ActionResult  Create(Employee empObj)
        {
            empList.Add(empObj);
            return Ok(new { status = "Success", message = "New employee details created in server" });
        }


        [HttpPut("{id}")]
        public ActionResult Update(int id,  Employee updatedEmpObj)
        {
           int index = empList.FindIndex(item => item.Id == id);

            if (index != -1)
            {
                 empList[index] = updatedEmpObj;
                //  empList[index].Salary = updatedEmpObj.Salary;
                return Ok(new { status = "Success", message = "New employee details updated in server" });
            }
            else
            {
                return NotFound(new { status = "Failed", message = "Requested employee id does not exists" });
            }

               
        }


        [HttpDelete("{id}")]
        public ActionResult  DeleteEmployeeById(int id)
        {
            Employee obj = empList.FirstOrDefault(item => item.Id == id);

            if (obj != null)
            {
                
                empList.Remove(obj);
                return Ok(new { status = "Success", message = "Requested employee detailed deleted from server" });
            }
                
            else
                return NotFound(new { status = "Failed", message = "Requested employee id does not exists" });
        }
    }
}
