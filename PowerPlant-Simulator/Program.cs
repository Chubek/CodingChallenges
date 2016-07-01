using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlant_Simulator
{
    class Program
    {
        public static int CalculateDays(int daysToSimulate)
        {
            if (daysToSimulate < 3)
                return 0;
            else if (daysToSimulate < 14)
                return daysToSimulate / 3;
            else if (daysToSimulate < 100)
                return (daysToSimulate / 3) + (daysToSimulate / 14);
            else
                return (daysToSimulate / 3) + (daysToSimulate / 14) + (daysToSimulate / 100);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("The powerplant goes offline every third day, and every hundred day. In 14th of the month, the powerpland is turned off.");
            Console.WriteLine("How many days would you like to simulate the powerplant for?");
            var daysToSimulate = int.Parse(Console.ReadLine());

            int daysReduced = CalculateDays(daysToSimulate);
            int daysToRemain = daysToSimulate - daysReduced;

            Console.WriteLine(daysToRemain);
           
            Console.ReadKey();
        }

        
    }
}
