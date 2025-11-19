using ProductsApi.Models;
using ProductsApi.Repositories;
using ProductsApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Moq;


namespace ProductsApi
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductRepository> _repoMock;
        private readonly ProductService _service;

        public ProductServiceTests()
        {
            _repoMock = new Mock<IProductRepository>();
            _service = new ProductService(_repoMock.Object);
        }

        [Fact]
        public async Task GetProductsAsync_ShouldReturnAllProducts()
        {
                // Arrange
                var list = new List<Product>
        {
            new Product { Id = 1, Name = "Item1", Price = 10, Category = "CatA" },
            new Product { Id = 2, Name = "Item2", Price = 20, Category = "CatB" }
        };


            _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(list);

            // Act
            var result = await _service.GetAllProductsAsync();

            // Assert
            Assert.Equal(2, result.ToList().Count);
        }


        [Fact]
        public async Task GetProductAsync_ShouldReturnProduct_WhenExists()
        {
            // Arrange
            var expected = new Product { Id = 1, Name = "Laptop", Price = 999, Category = "Electronics" };

            _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(expected);

            // Act
            var result = await _service.GetProductDetailsAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expected.Id, result.Id);
            Assert.Equal(expected.Name, result.Name);
        }


        [Fact]
        public async Task CreateProductAsync_ShouldAddProduct()
        {
            // Arrange
            var newProduct = new Product { Id = 10, Name = "New", Price = 50, Category = "General" };
             

            // Act
            await _service.CreateProductAsync(newProduct);

            // Assert
            Assert.Equal(10, newProduct.Id);
            _repoMock.Verify(r => r.AddAsync(newProduct), Times.Once);
        }


    }

}