using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("employee", false)]
        [InlineData("ABBA", true)]
        public void IsAPalindromeTester(string word, bool expected)
        {
            WordSmith palindromer = new WordSmith();
            var actual = palindromer.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new char[3] { 'a', 'b', 'c' },new char[] { 'c', 'b', 'a' })]

    public void ReversArrTester(char[] arr1, char[] expected)
    {
        //WordSmith reverser = new WordSmith();
        //    var actual = reverser.Reverse(arr1);
        //    Assert.Equal(actual, expected);


    }
    }
}
