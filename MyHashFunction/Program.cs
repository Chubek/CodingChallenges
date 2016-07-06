using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(MyHashFunction(word));
            Console.ReadKey();
        }

        static string MyHashFunction(string word)
        {

            Dictionary<char, int> myAlphabet = new Dictionary<char, int>()
            {
                {'A', 01 }, {'B', 02 }, {'C', 03 }, {'D', 04 }, {'E', 05 }, {'F', 06 },
                {'G', 07 }, { 'H', 08 }, {'I', 09 }, {'J', 10 }, {'K', 11 }, {'L', 12 },
                {'M', 13 }, {'N', 14 }, {'O', 15 }, {'P', 16 }, {'Q', 17 }, {'R', 18 },
                {'S', 19 }, {'T', 20 }, {'U', 21 }, {'V', 22 }, {'W', 23 }, {'X', 24 },
                {'Y', 25 }, {'Z', 26 }, {'0', 27 }, {'1', 28 }, {'2', 29 }, {'3', 30 },
                {'4', 31 }, {'5', 32 }, {'6', 33 }, {'7', 34 }, {'8', 35 }, {'9', 36 },
                {'!', 37 }, {'#', 38 }, {'$', 39 }, {'^', 40 }, {'&', 41 }, {'*', 42 },
                {'(', 43 }, {')', 44 }, {'-', 45 }, {'+', 46 }

            };

            List<char> myVowels = new List<char>() { 'E', 'O', 'A', 'I', 'U' };
            int numberOfVowels = 0;

            List<char> wordSplit = word.ToUpper().ToCharArray().ToList();
            
            foreach (var character in wordSplit)
            {
                foreach (var vowel in myVowels)
                {
                    if (character == vowel)
                    {
                        numberOfVowels += 1;
                    }
                }
            }

            string hash = "";

            foreach (var character in wordSplit)
            {
                hash += myAlphabet[character] + numberOfVowels;
                hash += "   ";
            }

            return hash;
            
        }
    }
}
