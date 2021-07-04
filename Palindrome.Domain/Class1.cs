using System;

namespace Palindrome.Domain
{
    public class Class1
    {
     

        public bool VerifyWord(string word)
        {
            bool ret = false;

            if(word.Length == 0)
                System.Console.WriteLine("Word cannot be empty string!");
            else
            {
                ret  = true;
            }
            
            return ret;
        }

        public bool isPalindrome(string word)
        {
            bool ret = false;

            if(VerifyWord(word))
            {
                word = word.ToLower();
                int leftIndex = 0;
                int rightIndex = word.Length - 1;

                var stay = true;

                while(stay)
                {
                    if(leftIndex < rightIndex)
                    {
                        if(word[leftIndex] != word[rightIndex])
                        {
                            stay = false;
                            ret =false;   
                        }
                        leftIndex++;
                        rightIndex--;
                    }
                    else
                    {
                        ret = true;
                        stay = false;
                    }
                }
            }
            else
            {
                ret = false;
            }

            return ret;
        }
    }
}
