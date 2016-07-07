using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_digitsDivisibleByM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n and m delimited by space");
            string input = Console.ReadLine();

            string[] inputSplit = input.Split();

            int maximum = BiggestNumber(int.Parse(inputSplit[0]));

            for (int i = maximum; i > 0; i--)
            {
                if (i % int.Parse(inputSplit[1]) == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadKey();

        }

        static int BiggestNumber(int i)
        {
            
            string ElevenPlus = new string('1', i);

            return 9 * int.Parse(ElevenPlus);
        }
    }
}
