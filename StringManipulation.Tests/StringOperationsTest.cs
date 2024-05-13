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

        [Fact]
        public void RemoveWhitespace()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.RemoveWhitespace("This is a test");

            // Assert.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Thisisatest", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.QuantintyInWords("Laptop", 1);

            // Assert.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.StartsWith("one", result.ToLower());
            Assert.Contains("laptop", result.ToLower());
            Assert.Equal("One laptop".ToLower(), result.ToLower());
        }

        [Fact]
        public void GetStringLength()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.GetStringLength("Julio");

            // Assert.
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Assert.
            Assert.ThrowsAny<ArgumentNullException>(() => strOperation.GetStringLength(null));
        }

        [Fact]
        public void TruncateString()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.TruncateString("Julio", 2);

            // Assert.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Ju", result);
        }

        [Fact]
        public void TruncateString_Exception()
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Assert.
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperation.TruncateString(null, 0));


        }


    }
}
