using Castle.Core.Logging;
using Humanizer;
using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact(Skip = "For the moment this test is not valid. Ticket-101")]
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

        [Theory]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]   
        public void FromRomanToNumber(string input, int expected)
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.FromRomanToNumber(input);

            // Assert.
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ana", true)]
        [InlineData("julio", false)]
        [InlineData("cesar", false)]
        public void IsPalindrome(string input, bool expected)
        {
            // Arrange.
            var strOperation = new StringOperations();

            // Act.
            var result = strOperation.IsPalindrome(input);

            // Assert.
            if(expected)
            {
                Assert.True(result);
            }

            if(!expected)
            {
                Assert.False(result);
            }

        
        }

        [Fact]
        public void CountOccurrences()
        {
            // Arrange.
            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperation = new StringOperations(mockLogger.Object);

            // Act.
            var result = strOperation.CountOccurrences("Demente", 'e');

            // Assert.
            Assert.Equal(3, result);    
        }

        [Fact]
        public void ReadFile()
        {
            // Arrange.
            var strOperation = new StringOperations();
            var mockFileReader = new Mock<IFileReaderConector>();
            // mockFileReader.Setup(p => p.ReadString("filename.txt")).Returns("Reading the file");
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading the file");

            // Act.
            var result = strOperation.ReadFile(mockFileReader.Object, "filename.txt");

            // Assert.
            var expected = "Reading the file";
            Assert.Equal(expected, result);

        }


    }
}
