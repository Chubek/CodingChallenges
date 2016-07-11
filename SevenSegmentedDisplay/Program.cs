using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Digital(i));
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

        static string Digital(int number)
        {
            string line = "+--+";
            string pluses = "+  +";
            string parallel = "|  |";
            string parallelLeft = "|   ";
            string parallelRight = "   |";
            string newLine = "\n";


            Dictionary<int, string> digits = new Dictionary<int, string>()
            {
                {0, line + newLine + parallel + newLine + parallel + newLine + pluses + newLine + parallel + newLine + parallel + newLine + line },
                {1, "+" + newLine + parallelLeft + newLine + parallelLeft + newLine + "+" + newLine + parallelLeft + newLine + parallelLeft + newLine + parallelLeft + newLine + "+" },
                {2, line + newLine + parallelRight + newLine + parallelRight + newLine + line + newLine + parallelLeft + newLine + parallelLeft + newLine + line },
                {3, line + newLine + parallelRight + newLine + parallelRight + newLine + line + newLine + parallelRight + newLine + parallelRight + newLine + line },
                {4, pluses + newLine + parallel + newLine + parallel + newLine + line + newLine + parallelRight + newLine + parallelRight + newLine + "   +" },
                {5, line + newLine + parallelLeft + newLine + parallelLeft + newLine + line + newLine + parallelRight + newLine + parallelRight + newLine + line },
                {6, line + newLine + parallelLeft + newLine + parallelLeft + newLine + line + newLine + parallel + newLine + parallel + newLine + line },
                {7, line + newLine + parallelRight + newLine + parallelRight + newLine + "   +" + newLine + parallelRight + newLine + parallelRight + newLine + "   +" },
                {8, line + newLine + parallel + newLine + parallel + newLine + line + newLine + parallel + newLine + parallel + newLine + line  },
                {9, line + newLine + parallel + newLine + parallel + newLine + line + parallelRight + newLine + parallelRight + newLine + line }
            };
            
            



            return digits[number];

            
        }
    }
}
