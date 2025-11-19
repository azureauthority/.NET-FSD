using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductsApi.Controllers;
using ProductsApi.Models;
using ProductsApi.Services;
using Xunit;

namespace ProductsApi.Tests
{    
    public class ProductControllerTests
    {
        private readonly Mock<IProductService> _serviceMock;
        private readonly ProductsController _controller;

        public ProductControllerTests()
        {
            _serviceMock = new Mock<IProductService>();
            _controller = new ProductsController(_serviceMock.Object);
        }

        [Fact]
        public async Task GetProducts_ShouldReturnOk_WithListOfProducts()
        {
            // Arrange
            var list = new List<Product>
    {
        new Product { Id = 1, Name = "A", Price = 10, Category = "CAT1" },
        new Product { Id = 2, Name = "B", Price = 20, Category = "CAT2" }
    };

            _serviceMock.Setup(s => s.GetAllProductsAsync()).ReturnsAsync(list);

            // Act
            var actionResult = await _controller.GetAll();
            var result = actionResult.Result as OkObjectResult;

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var products = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
            Assert.Equal(2, new List<Product>(products).Count);
        }




        [Fact]
        public async Task GetProduct_ShouldReturnOk_WhenProductExists()
            {
            // Arrange
            var product = new Product { Id = 1, Name = "Test", Price = 100, Category = "Cat" };

            _serviceMock.Setup(s => s.GetProductDetailsAsync(1)).ReturnsAsync(product);

            // Act
            var actionResult = await _controller.GetById(1);
            var result = actionResult.Result as OkObjectResult;

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedProduct = Assert.IsType<Product>(okResult.Value);
            Assert.Equal(product.Id, returnedProduct.Id);
        }


        [Fact]
        public async Task GetProduct_ShouldReturnNotFound_WhenProductDoesNotExist()
        {
            // Arrange
            _serviceMock.Setup(s => s.GetProductDetailsAsync(1)).ReturnsAsync((Product)null);

            // Act
            var actionResult = await _controller.GetById(1);           
            var result = actionResult.Result as NotFoundObjectResult;

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }


       
        [Fact]
        public async Task CreateProduct_ShouldReturnCreated()
        {
            // Arrange
            var product = new Product { Id = 10, Name = "New", Price = 50, Category = "General" };

            // Act
            var result = await _controller.Create(product);

            // Assert
            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            dynamic response = okResult.Value;

            Assert.Equal("New Resource created in server", (string)response.message);

            // Verify service method is called once
            _serviceMock.Verify(s => s.CreateProductAsync(product), Times.Once);
        }


    }

}
