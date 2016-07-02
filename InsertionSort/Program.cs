using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 3, 52, 2, 42, 32, 1, 4 };

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && (array[j] < array[j - 1]))
                {
                    SwapArray(array, j, j - 1);
                    j -= 1;
                }
            }

        }

        static void SwapArray(int[] array, int element1, int element2)
        {
            int temp = array[element1];
            array[element1] = array[element2];
            array[element2] = temp;

        }
    }
}
