using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPremutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> myList = Scramble(input);

            foreach (var word in myList)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }

        static char[] SwapArray(char[] myCharArray, int indexOne, int indexTwo)
        {
            char temp = myCharArray[indexOne];
            myCharArray[indexOne] = myCharArray[indexTwo];
            myCharArray[indexTwo] = temp;

            return myCharArray;  
        }

        static List<string> Scramble(string text)
        {
            char[] textSplit = text.ToCharArray();
            List<char> iterations = new List<char>();
            List<string> scrambledWords = new List<string>();

            for (int i = 0; i < textSplit.Length; i++ )
                for (int j = 0; j < textSplit.Length; j++)
                {
                    iterations.AddRange(SwapArray(textSplit, i, j));
                }

            for (int i = 0; i < iterations.Count; i++)
            {
                if (iterations.Count - i >= textSplit.Length)
                {

                    string temp = new String(iterations.ToArray(), i, textSplit.Length);
                    scrambledWords.Add(temp);
                }
                


            }

            return scrambledWords;

        }

    }
}
