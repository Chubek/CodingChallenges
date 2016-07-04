using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 7, 8, 3, 5, 6, 7 };

            ReverseNElements(myArray, 5);

        }

        static void SwapArray(int[] givenarray, int element1, int element2)
        {
            int temp = givenarray[element1];
            givenarray[element1] = givenarray[element2];
            givenarray[element2] = temp;
        }

        static void ReverseNElements(int[] givenarray, int n)
        {
            if (n == 1 || n == 0)
            {
                return;
            }
            else if (n > givenarray.Length)
            {
                throw new Exception("Your block was larger than the array");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    SwapArray(givenarray, i, i + 1);
                }
            }
        }
    }
}
