namespace AonExercise.Test
{
    public class ArrayUtilityTest
    {
        [Fact]
        public void EmptyArrays_Should_Return_EmptyArray()
        {
            // Arrange
            var array1 = Array.Empty<int>();
            var array2 = Array.Empty<int>();

            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(Array.Empty<int>(), output);
        }

        [Fact]
        public void NullArrays_Should_Return_EmptyArray()
        {
            // Arrange
            int[] array1 = null;
            int[] array2 = null;

            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(Array.Empty<int>(), output);
        }


        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 2, 4, 6, 8, 10 })]
        [InlineData(new int[] { 4, 6, 9, 13, 20 })]
        public void EmptyFirstArray_Should_Return_SecondArray(int[] array2)
        {
            // Arrange
            var array1 = Array.Empty<int>();
            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(array2, output);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 2, 4, 6, 8, 10 })]
        [InlineData(new int[] { 4, 6, 9, 13, 20 })]
        public void EmptySecondArray_Should_Return_FirstArray(int[] array1)
        {
            // Arrange
            var array2 = Array.Empty<int>();

            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(array1, output);
        }

        [Fact]
        public void TwoArrays_SameLength_Should_Return_MergedArray()
        {
            // Arrange
            var array1 = new int[] { 1, 3, 5, 7, 9 };
            var array2 = new int[] { 2, 4, 6, 8, 10 };

            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 }, output);
        }


        [Fact]
        public void TwoArrays_FirstShorterThanSecond_Should_Return_MergedArray()
        {
            // Arrange
            var array1 = new int[] { 1, 3, 5 };
            var array2 = new int[] { 2, 4, 6, 8, 10 };

            // Act
            var output = ArrayUtility.MergeSortedArrays(array1, array2);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 8, 10 }, output);
        }


    }
}
