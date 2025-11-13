using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext _context;
         
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return  await  _context.Products.ToListAsync();
        }
        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Product? obj =  await _context.Products.FindAsync(id);
            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
