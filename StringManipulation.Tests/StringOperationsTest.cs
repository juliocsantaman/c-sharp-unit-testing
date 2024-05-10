namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.ConcatenateStrings("Hello", "World");

            // Assert.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.IsPalindrome("Ana");

            // Assert.
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.IsPalindrome("Test");

            // Assert.
            Assert.False(result);
        }

    }
}
