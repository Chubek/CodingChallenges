using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence of letters seperated by a by spaces:");
            string sequenceOfWords = Console.ReadLine();

            char[] seperator = { ' ' };
            string[] WordsSplit = sequenceOfWords.Split(seperator);

            for (int i = 0; i < WordsSplit.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(WordsSplit[i]);
                }
                else
                {
                    char[] wordSplitSPlit = WordsSplit[i].ToCharArray();
                    int multiplier = (WordsSplit[i - 1].Length) - 1;
                    string spaces = new string(' ', multiplier);

                    foreach (var character in wordSplitSPlit)
                    {
                        Console.WriteLine(spaces + character);
                    }
                }
            }

            Console.ReadKey();
        }

    }
}
