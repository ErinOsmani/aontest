using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AonExercise.Test
{
    public class FibonacciCalculatorTest
    {

        [Theory]
        [InlineData(-1)]
        [InlineData(-40)]
        [InlineData(-500)]
        public void NegativeNumber_Should_ReturnException(int input)
        {
            // Arrange
            var calculator = new OptimizedFibonacciCalculator();

            // Act
            Action action = () => calculator.Calculate(input);

            // Assert
            ArgumentException output = Assert.Throws<ArgumentException>(action);
            Assert.Equal("n should be greater than or equal to 0", output.Message);
        }

        [Fact]
        public void Zero_Should_ReturnZero()
        {
            // Arrange
            var input = 0;
            var calculator = new OptimizedFibonacciCalculator();

            // Act
            var output = calculator.Calculate(input);

            // Assert
            Assert.Equal(0, output);
        }



        [Fact]
        public void Eight_Should_ReturnCorrect()
        {
            // Arrange
            var input = 8;
            var calculator = new OptimizedFibonacciCalculator();

            // Act
            var output = calculator.Calculate(input);

            // Assert
            Assert.Equal(21, output);
        }


        [Fact]
        public void Eleventh_Should_ReturnCorrect()
        {
            // Arrange
            var input = 11;
            var calculator = new OptimizedFibonacciCalculator();

            // Act
            var output = calculator.Calculate(input);

            // Assert
            Assert.Equal(89, output);
        }
    }
}
