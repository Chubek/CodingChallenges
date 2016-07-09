using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteniaATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int zeroes = 0;

            List<int> myList = ATM(input);
            
            foreach(var number in myList.ToArray())
            {
                if (number != 0)
                {
                    myList.AddRange(ATM(number));
                }
                else
                {
                    continue;
                }
            }

            foreach (var zero in myList)
            {
                if (zero == 0)
                {
                    zeroes += 1;
                }
            }

            Console.WriteLine(zeroes);
            Console.ReadKey();

            
            Console.ReadKey();
        }

        static List<int> ATM(int value)
        {
            List<int> exchangeCoins = new List<int>();

            if (value != 0)
            {
                exchangeCoins.Add(value / 2);
                exchangeCoins.Add(value / 3);
                exchangeCoins.Add(value / 4);
            }
           else
            {
                throw new Exception("Value can't be zero!");
            }

            return exchangeCoins;

        }
    }
}
