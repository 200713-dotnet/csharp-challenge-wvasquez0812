using System;

namespace Palindrome.Domain
{
    public class Class1
    {
     

        public string getWord()
        {
            System.Console.WriteLine("Welcome to Palindrome Checker. Enter word to be checked: ");
            var word = System.Console.ReadLine().ToLower();

            return word;

        }

        public bool isPalindrome(string word)
        {

             
            int leftIndex = 0;
            int rightIndex = word.Length - 1;

            bool isPalindrome = false;
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
                    leftIndex++;
                    rightIndex--;
                }
                else
                {
                    stay = false;
                }

            }

            return isPalindrome;
        }
    }
}
