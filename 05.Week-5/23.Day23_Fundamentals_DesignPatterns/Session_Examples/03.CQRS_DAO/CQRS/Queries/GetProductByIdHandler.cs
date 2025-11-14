using CQRSDemoApplication.Data;
using CQRSDemoApplication.Models;


namespace CQRSDemoApplication.CQRS.Queries
{
    public class GetProductByIdHandler
    {
        private readonly IProductDao _dao;

        public GetProductByIdHandler(IProductDao dao)
        {
            _dao = dao;
        }

        public Task<Product?> Handle(GetProductByIdQuery query)
        {
            return _dao.GetByIdAsync(query.Id);
        }
    }

}