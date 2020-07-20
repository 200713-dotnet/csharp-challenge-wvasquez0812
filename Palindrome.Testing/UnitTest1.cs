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
            
            Class1 testPalindrome = new Class1();

            
            Assert.IsTrue(testPalindrome.isPalindrome(word));

            Assert.IsFalse(testPalindrome.isPalindrome(word2));
        }
    }
}
