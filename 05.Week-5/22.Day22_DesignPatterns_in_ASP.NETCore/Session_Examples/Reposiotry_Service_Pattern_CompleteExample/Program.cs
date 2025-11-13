
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
using ProductsApi.Repositories;
using ProductsApi.Services;

namespace ProductsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Configure/Register DbContext class for  Oracle EF Core
            builder.Services.AddDbContext<AppDbContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));
;
            // Register Product Service and Product Repository
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
