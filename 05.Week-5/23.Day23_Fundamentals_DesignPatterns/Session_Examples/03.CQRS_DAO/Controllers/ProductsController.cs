using CQRSDemoApplication.CQRS.Commands;
using CQRSDemoApplication.CQRS.Queries;
using CQRSDemoApplication.Data;
using CQRSDemoApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDemoApplication.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDao _dao;

        public ProductsController(IProductDao dao)
        {
            _dao = dao;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var handler = new GetProductByIdHandler(_dao);
            var result = await handler.Handle(new GetProductByIdQuery(id));

            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand cmd)
        {
            var handler = new CreateProductHandler(_dao);
            Product obj =  await handler.Handle(cmd);
            return Ok(new {  Message  = "New Product created in Server", ProductObj = obj});
        }
    }

}