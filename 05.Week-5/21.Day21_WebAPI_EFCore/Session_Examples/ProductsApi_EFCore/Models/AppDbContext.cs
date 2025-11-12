using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductsApi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // TABLE name => UPPERCASE
                entity.SetTableName(entity.GetTableName().ToUpper());

                // COLUMN names => UPPERCASE
                foreach (var prop in entity.GetProperties())
                {
                    var tableName = entity.GetTableName();
                    var columnName =
                    prop.GetColumnName(StoreObjectIdentifier.Table(tableName, entity.GetSchema()));
                    prop.SetColumnName(columnName.ToUpper());
                }
            }


        }
    }
}
