using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1");
            double X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1");
            double Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2");
            double X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2");
            double Y2 = double.Parse(Console.ReadLine());

            double[] coordinates1 = { X1, Y1 };
            double[] coordinates2 = { X2, Y2 };

            double distance = FindDistance(coordinates1, coordinates2);

            Console.WriteLine("Your distance is " + distance);
            Console.ReadKey();
            
        }

        static double FindDistance (double[] coordinates1, double[] coordinates2)
        {
            if (coordinates1.Length > 2 || coordinates2.Length > 2 )
                throw new Exception("Only two-dimensional points are accepted");

            double X1 = coordinates1[0];
            double Y1 = coordinates1[1];

            double X2 = coordinates2[0];
            double Y2 = coordinates2[1];

            return Math.Sqrt((Math.Pow((X2 - X1), 2) - Math.Pow((Y2 - Y1), 2)));
            
        }
    }
}
