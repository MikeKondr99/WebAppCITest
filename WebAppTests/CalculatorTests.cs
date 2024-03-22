using Xunit;
using CoverageDemo;
using WebAppLibrary;

namespace CoverageDemo.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            int result = _calculator.Add(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_PositiveNumbers_ReturnsDifference()
        {
            int result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_NegativeNumbers_ReturnsDifference()
        {
            int result = _calculator.Subtract(3, 5);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            int result = _calculator.Multiply(5, 3);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            int result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
        }

        [Fact]
        public void Factorial_PositiveNumber_ReturnsFactorial()
        {
            int result = _calculator.Factorial(5);
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_NegativeNumber_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(-5));
        }
    }
}