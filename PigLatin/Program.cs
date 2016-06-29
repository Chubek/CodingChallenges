using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            string firstLetterPlusAy = charArray[0] + "ay";
            string minusFirstLetter = word.Remove(0, 1);
            Console.WriteLine(minusFirstLetter + firstLetterPlusAy);
                       
            
            Console.ReadKey();
        }
    }
}
