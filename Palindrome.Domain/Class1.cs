using System;

namespace Palindrome.Domain
{
    public class Class1
    {
        public static void  Main()
        {
            System.Console.WriteLine("Welcome to Palindrome Checker. Enter word to be checked: ");
            var word = System.Console.ReadLine().ToLower();
            
            int leftIndex = 0;
            int rightIndex = word.Length - 1;
            
        
        }

        public bool isPalindrome(string word, int leftIndex, int rightIndex)
        {
            bool isPalindrome;
            bool stay = true;

            while(stay)
            {
                if(leftIndex < rightIndex)
                {
                    if(word[leftIndex] != word[rightIndex])
                    {
                        stay = false;
                        isPalindrome =false;   
                    }
                }
                else
                {
                    stay = false;
                }
            }
        }
    }
}
