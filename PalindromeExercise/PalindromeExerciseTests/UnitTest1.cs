using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("KaYaK", true)]
        [InlineData("kayak", true)]
        [InlineData("palindrome", false)]
        [InlineData("T", true)]
        public void IsAPalindromeTest(string str, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
