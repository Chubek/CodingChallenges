using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        public static int CountOccurances(string word, List<char> oddities)
        {
            int count = 0;
            List<char> wordSplit = word.ToCharArray().ToList();

            for (int i = 0; i < wordSplit.Count; i++)
            {
                if (oddities.Contains(wordSplit[i]))
                    count += 1;
            }

            return count;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] characters = { 'e', 'E', 'a', 'A', 'o', 'O', 'i', 'I' };
            List<char> oddities = new List<char>();
            oddities.AddRange(characters);

            string countVowels = CountOccurances(word, oddities).ToString();
            Console.WriteLine(countVowels);
            Console.ReadKey();
          


                        
            
        }

        
    }
}
