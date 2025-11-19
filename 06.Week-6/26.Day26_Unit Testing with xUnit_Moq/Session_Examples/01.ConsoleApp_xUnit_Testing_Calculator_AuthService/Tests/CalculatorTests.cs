using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp4.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_TwoNumbers_ReturnSum()
        {
            // Arrange
            Calculator calculatorObj = new Calculator();

            // Act
            int result  =  calculatorObj.Sum(10, 20);

            // Assert
            Assert.Equal(30, result);
        }



        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        [InlineData(0, 0, 0)]
        public void Sum_ShouldWorkForVariousInputs(int a, int b, int expected)
        {
            Calculator calculatorObj = new Calculator();
            int result = calculatorObj.Sum(a, b);
            Assert.Equal(expected, result);
        }
    }
}
