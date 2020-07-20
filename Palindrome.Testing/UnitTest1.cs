using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var word = "radar";
            var word2 = "hello";
            
            Palindrome.Domain.Class1 testPalindrome = new Class1();

            
            
            Assert.True(testPalindrome.isPalindrome(word));

            Assert.False(testPalindrome.isPalindrome(word2));
        }
    }
}
