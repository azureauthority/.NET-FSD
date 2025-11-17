using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {  

            List<Product> productsList = _context.Products.Include(p => p.Orders).ToList();

            return Ok(productsList);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var obj = _context.Products
                        .Include(p => p.Orders)
                         .SingleOrDefault(u => u.Id == id);


            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new { Message = "Requested Deptno does not exists" });
            }
          
        }



        [HttpPost]
        public ActionResult<List<Product>> Create(Product obj)
        {
            _context.Products.Add(obj);

            //  Create/Update/Delete  ----  Save the changes in databse
            _context.SaveChanges();

            return Ok(new { message = "New Resource created in server" });
        }
    }
}
