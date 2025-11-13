using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Services;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
       
        public ProductsController(IProductService productService)
        {
            _productService = productService; 
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var productsList = await _productService.GetAllProductsAsync();
            return Ok(productsList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var obj = await _productService.GetProductDetailsAsync(id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new { message = "Requested resource not found." });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product obj)
        {
            await _productService.CreateProductAsync(obj);
            return Ok(new { message = "New Resource created in server" });
        }

        [HttpPut]
        public async Task<ActionResult> Update(Product obj)
        {
            await _productService.UpdateProductAsync(obj);
            return Ok(new { message = "Resource updated in server" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var obj = await _productService.GetProductDetailsAsync(id);
            
            if (obj == null)
            {
                return NotFound(new { message = "Requested resource not found." });
            }


            await _productService.DeleteProductAsync(id);
            return Ok(new { message = "Resource deleted from server" });

        }

    }
}
