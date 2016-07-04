using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSeperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string removedLetter = SeperateChars(word);

            Console.WriteLine(RemoveWord(word, removedLetter) + ", " + removedLetter);
            Console.ReadKey();
        }

        static string SeperateChars(string word)
        {
            string secondInstance = "";
            char[] wordSplit = word.ToCharArray();

            for (int i = 1; i < wordSplit.Length; i++)
            {
                if (wordSplit[i] == wordSplit[i - 1])
                {
                    secondInstance += wordSplit[i];
                }
            }

            return secondInstance;
        }

        static string RemoveWord(string word1, string word2)
        {
            char[] wordOneSplit = word1.ToCharArray();
            char[] wordTwoSplit = word2.ToCharArray();
            List<char> wordFinal = new List<char>();

            for (int i = 0; i < wordOneSplit.Length; i++)
            {
                for (int j = 0; j < wordTwoSplit.Length; j++)
                {
                    if (wordOneSplit[i] != wordTwoSplit[j])
                    {
                        wordFinal.Add(wordOneSplit[i]);
                    }
                }
            }

            char[] wordFinalArray = wordFinal.ToArray();

            return new string(wordFinalArray);
        }

        
    }
}
