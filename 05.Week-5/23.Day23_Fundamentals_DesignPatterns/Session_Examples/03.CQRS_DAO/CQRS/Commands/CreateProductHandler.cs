using CQRSDemoApplication.CQRS.Commands;
using CQRSDemoApplication.Data;
using CQRSDemoApplication.Models;

namespace CQRSDemoApplication.CQRS.Commands
{

    public class CreateProductHandler
    {
        private readonly IProductDao _dao;

        public CreateProductHandler(IProductDao dao)
        {
            _dao = dao;
        }

        public async Task<Product>  Handle(CreateProductCommand cmd)
        {
            var product = new Product
            {
                Name = cmd.Name,
                Price = cmd.Price,
                Category = cmd.Category                
            };

            Product obj =  await _dao.CreateAsync(product);
            return obj;
        }
    }

}