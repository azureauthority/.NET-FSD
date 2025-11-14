using CQRSDemoApplication.Models;
 

namespace CQRSDemoApplication.Data
{
    public interface IProductDao
    {
        Task<Product?> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product);
    }
}

