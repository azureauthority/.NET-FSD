using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private AppDbContext _context;
        public OrdersController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {

            var orders = _context.Orders.ToList();            
            return Ok(orders);
        }

         
        [HttpPost]
        public ActionResult Create(Order obj)
        {
            _context.Orders.Add(obj);

            //  Create/Update/Delete  ----  Save the changes in databse
            _context.SaveChanges();

            return Ok(new { message = "New Resource created in server" });
        }
    }
}
