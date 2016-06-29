using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] wordSplit = word.ToCharArray();
            int vowelCount = 0;

            for (int i = 0; i < wordSplit.Length; i++)
            {
                if (wordSplit[i] == 'e' || wordSplit[i] == 'a' || wordSplit[i] == 'u' || wordSplit[i] == 'i' || wordSplit[i] == 'o' ||
                   wordSplit[i] == 'E' || wordSplit[i] == 'A' || wordSplit[i] == 'U' || wordSplit[i] == 'I' || wordSplit[i] == 'O')
                {
                    vowelCount += 1;
                }
                else
                    continue;
            }

            Console.WriteLine(vowelCount);
            Console.ReadKey();
        }
    }
}
