using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonStatisticalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double>() { 2, 4, 4, 4, 5, 5, 7, 9 };

            Console.WriteLine(Mean(myList));
            for (int i = 0; i < Deviation(myList).Count; i++)
            {
                Console.WriteLine(Deviation(myList)[i]);
            }
            Console.WriteLine(Variance(myList));

            Console.ReadKey();

        }

        static double Mean(List<double> myList)
        {
            double sum = 0;
            int i = myList.Count - 1;
            while (i >= 0)
            {
                sum += myList[i];
                i -= 1; 
            }

            return sum / myList.Count;
        }

        static List<double> Deviation(List<double> myList)
        {
            double mean = Mean(myList);
            List<double> deviatedList = new List<double>();

            for (int i = 0; i < myList.Count; i++)
            {
                deviatedList.Add(Math.Pow((myList[i] - mean), 2));
            }

            return deviatedList;
            

        }

        static double Variance(List<double> myList)
        {
            List<double> deviatedList = Deviation(myList);

            double sum = 0;
            int i = deviatedList.Count - 1;
            while (i >= 0)
            {
                sum += deviatedList[i];
                i -= 1;
            }

            return sum / deviatedList.Count;
        }
    }
}
