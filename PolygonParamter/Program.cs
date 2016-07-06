using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please separate n and R by space");
            string input = Console.ReadLine();
            char[] delimiter = { ' ' };            
            string[] inputSplit = input.Split(delimiter);

            Console.WriteLine(CalculateParameter(int.Parse(inputSplit[0]), double.Parse(inputSplit[1])));
            Console.ReadKey();

        }

        static double CalculateParameter(int n, double R)
        {
            double s = R * (2 * Math.Sin(Math.PI / n));

            return n * s;

        }
    }
}
