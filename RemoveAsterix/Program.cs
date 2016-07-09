using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoceAsterixCC
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(RemoveAsterix(input));
            Console.ReadKey();
        }

        static string RemoveAsterix(string myString)
        {
            if (!(myString.Contains('*')))
            {
                throw new Exception("You need an asterix!");
            }

            List<char> myStringSplit = myString.ToCharArray().ToList();

            if (myStringSplit[0] == '*')
            {
                myStringSplit.RemoveRange(0, 2);
                
            }

            if (myStringSplit[myStringSplit.Count - 1] == '*')
            {
                myStringSplit.RemoveRange(myStringSplit.Count - 2, 2);
                
            }

            for (int i = 1; i < myStringSplit.Count - 1; i++)
            {
                if (myStringSplit[i] == '*')
                {
                    myStringSplit.RemoveRange(i - 1, 3);
                    break;
                }
            }

            return new string(myStringSplit.ToArray());

        }
    }
}
