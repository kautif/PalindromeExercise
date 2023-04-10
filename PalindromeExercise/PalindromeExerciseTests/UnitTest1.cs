using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.  

        // For example [InlineData(“racecar”, true)]
        public void Test1(string word, bool expected)
        {
            // Arrange
            WordSmith palinCheck = new WordSmith();
            // Act
            var actual = palinCheck.IsPalinDrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
