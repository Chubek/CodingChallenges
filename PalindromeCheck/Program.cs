using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Check
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] wordSplit = word.ToCharArray();
            Array.Reverse(wordSplit);
            string reversedWord = new string(wordSplit);
            string palindromeStatus;
                        
            if (word.Equals(reversedWord))
            {
                palindromeStatus = "is";
            }
            else
            {
                palindromeStatus = "is not";
            }

            
            string wordUpperCase = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(word);

            Console.WriteLine("{0} reversed is {1} which means {0} {2} a palindrome.", wordUpperCase, reversedWord, palindromeStatus);

            Console.ReadKey();

        }
    }
}
