using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexityOfSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(0, "");
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");
            myDictionary.Add(4, "Four");
            myDictionary.Add(5, "Five");
            myDictionary.Add(6, "Six");
            myDictionary.Add(7, "Seven");
            myDictionary.Add(8, "Eight");
            myDictionary.Add(9, "Nine");

            myDictionary.Add(10, "Ten");
            myDictionary.Add(11, "Eleven");
            myDictionary.Add(12, "Twelve");
            myDictionary.Add(13, "Thirteen");
            myDictionary.Add(14, "Fourteen");
            myDictionary.Add(15, "Fifteen");
            myDictionary.Add(16, "Sixteen");
            myDictionary.Add(17, "Seventeen");
            myDictionary.Add(18, "Eighteen");
            myDictionary.Add(19, "Nineteen");

            myDictionary.Add(20, "Twenty");
            myDictionary.Add(30, "Thirty");
            myDictionary.Add(40, "Forty");
            myDictionary.Add(50, "Fifty");
            myDictionary.Add(60, "Sixty");
            myDictionary.Add(70, "Seventy");
            myDictionary.Add(80, "Eighty");
            myDictionary.Add(90, "Ninety");

            for (int i = 99; i > 0; i--)
            {
                int remainder = i % 10;

                if (i > 1 && i < 10)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[i], myDictionary[i - 1]);
                if (i > 10 && i < 20)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it aroun, {1} Botles of beer on the wall ",
                        myDictionary[i], myDictionary[i - 1]);

                if (i == 10)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[10], myDictionary[9]);
                if (i == 20)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[20], myDictionary[19]);
                if (i == 30)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[30], myDictionary[20] + myDictionary[9]);
                if (i == 40)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[40], myDictionary[30] + myDictionary [9]);
                if (i == 50)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[50], myDictionary[40] + myDictionary[9]);
                if (i == 60)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[60], myDictionary[50] + myDictionary [9]);
                if (i == 70)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[70], myDictionary[60] + myDictionary[9]);
                if (i == 80)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[80], myDictionary[70] + myDictionary[9]);
                if (i == 90)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                        myDictionary[90], myDictionary[80] + myDictionary[9]);

                if (i > 20 && i < 30)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[20] + myDictionary[remainder], myDictionary[20] + myDictionary[(remainder) - 1]);
                if (i > 30 && i < 40)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[30] + myDictionary[remainder], myDictionary[30] + myDictionary[(remainder) - 1]);
                if (i > 40 && i < 50)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[40] + myDictionary[remainder], myDictionary[40] + myDictionary[(remainder) - 1]);
                if (i > 50 && i < 60)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[50] + myDictionary[remainder], myDictionary[50] + myDictionary[(remainder) - 1]);
                if (i > 60 && i < 70)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[60] + myDictionary[remainder], myDictionary[60] + myDictionary[(remainder) - 1]);
                if (i > 70 && i < 60)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[70] + myDictionary[remainder], myDictionary[70] + myDictionary[(remainder) - 1]);
                if (i > 80 && i < 90)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[80] + myDictionary[remainder], myDictionary[80] + myDictionary[(remainder) - 1]);
                if (i > 90 && i < 100)
                    Console.WriteLine("{0} Bottles of beer on the wall, {0} bottles of beer, \n Take one down, pass it around, {1} Bottle of beer on the wall ",
                            myDictionary[90] + myDictionary[remainder], myDictionary[90] + myDictionary[(remainder) - 1]);










            }

            Console.ReadKey();
        }
    }
}
