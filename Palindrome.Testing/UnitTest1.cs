using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Radar")]
        public void GetWord_TrueTest(string word)
        {
            Class1 palindrome = new Class1();

            Assert.True(palindrome.VerifyWord(word));
        }
        [Theory]
        [InlineData("")]
        public void GetWord_FalseTest(string word)
        {

            Class1 palindrome = new Class1();

            Assert.False(palindrome.VerifyWord(word));
        }

        [Theory]
        [InlineData("Radar")]
        public void IsPalindrome_TrueTest(string word)
        {
            Class1 palindrome = new Class1();

            Assert.True(palindrome.isPalindrome(word));
        }
       
    }
}
