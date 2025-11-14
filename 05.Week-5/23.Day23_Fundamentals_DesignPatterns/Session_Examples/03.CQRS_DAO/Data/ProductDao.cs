using CQRSDemoApplication.Data;
using CQRSDemoApplication.Models;
using Microsoft.EntityFrameworkCore;
 
 
namespace CQRSDemoApplication.Data
{
 
public class ProductDao : IProductDao
{
    private readonly AppDbContext _context;

    public ProductDao(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }
       

    public async Task<Product> CreateAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }
}

}