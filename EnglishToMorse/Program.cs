using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode_Translator
{
    class Program
    {
        public static Dictionary<string, string> MyMorseLetters = new Dictionary<string, string>()
        {
            {"A", ".-" },
            {"B", "-..." },
            {"C", "-.-." },
            {"D", "-.." },
            {"E", "." },
            {"F", "..-." },
            {"G", "--." },
            {"H", "...." },
            {"I", ".." },
            {"J", ".---" },
            {"K", "-.--" },
            {"L", ".-.." },
            {"M", "--" },
            {"N", "-." },
            {"O", "---" },
            {"P", ".--." },
            {"Q", "--.-" },
            {"R", ".-." },
            {"S", "..." },
            {"T", "-" },
            {"U", "..-" },
            {"V", "...-" },
            {"W", ".--" },
            {"X", "-..-" },
            {"Y", "-.--" },
            {"Z", "--.." },

            {"1", ".----" },
            {"2", "..---" },
            {"3", "...--" },
            {"4", "....-" },
            {"5", "....." },
            {"6", "-...." },
            {"7", "--..." },
            {"8", "---.." },
            {"9", "----." },
            {"0", "-----" },

            {",", "--..--" },
            {".", ".-.-.-" },
            {"?", "..--.." },
            {"/", "-..-." },
            {"-", "-....-" },
            {"(", "-.--.-" },
            {")", "-.--.-" },

            {" ", "[Space]" }
        };

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            Console.WriteLine(ConvertToMorse(input));

            Console.ReadKey();
            
        }

        static string ConvertToMorse(string input)
        {

            char[] inputSplit = input.ToCharArray();
            string translated = "";
            

            foreach (char character in inputSplit)
            {
                translated += MyMorseLetters[character.ToString()];
                translated += " ";
            }

            return translated;
        }
    }
}
