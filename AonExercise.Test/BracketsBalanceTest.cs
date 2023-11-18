namespace AonExercise.Test
{
    public class BracketsBalanceTest
    {

        [Fact]
        public void EmptyString_Should_ReturnTrue()
        {
            // Arrange
            string input = "";

            // Act
            var isBalanced = StringUtility.IsBracketsBalanced(input);

            // Assert
            Assert.True(isBalanced);
        }


        [Fact]
        public void Null_Should_ReturnTrue()
        {
            // Arrange
            string input = null;

            // Act
            var isBalanced = StringUtility.IsBracketsBalanced(input);

            // Assert
            Assert.True(isBalanced);
        }

        [Fact]
        public void BalancedString_Should_ReturnTrue()
        {
            // Arrange
            var input = "{([])}";

            // Act
            var isBalanced = StringUtility.IsBracketsBalanced(input);

            // Assert
            Assert.True(isBalanced);
        }


        [Theory]
        [InlineData("(")]
        [InlineData("[")]
        [InlineData("{")]
        [InlineData("([)]")]
        [InlineData("()()(")]
        public void UnbalancedInput_ShouldReturnFalse(string input)
        {
            // Act
            bool result = StringUtility.IsBracketsBalanced(input);

            // Assert
            Assert.False(result);
        }


    }
}