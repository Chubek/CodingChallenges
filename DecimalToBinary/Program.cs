using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    
    class Program
    {
        public static List<int> returnList = new List<int>();
        
        static void Main(string[] args)
        {
            DecimalToBinary(156);
        }

        static List<int> DecimalToBinary(int deniry)
        {
            List<int> remainders = new List<int>();

            int divided = Division(deniry);
            returnList.Add(deniry);

            foreach (var number in returnList)
            {
                if (number % 2 == 0)
                {
                    remainders.Add(0);
                }
                else
                {
                    remainders.Add(1);
                }
            }
            

            remainders.Reverse();

            return remainders;
        }

        static int Division(int number)
        {
            
            int numberTwo = 0;

            if (number != 1)
            {
                numberTwo = number / 2;
                returnList.Add(numberTwo);
                return Division(numberTwo);

               
               
            }

            else
            {
                return 1;
            }
           
           
            
        }

    }
}
