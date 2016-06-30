using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            //sliding window problem goes like this: we have an array, and this array has i members. We insert a window of w into the array. 
            //For example, if array[6] = {1, 2, 3, 4, 5, 6}, the window is window[w = 3] = {1, {2, 3, 4}, 5, 6}
            //Find window maximum and window minimum
            //let's solve this shit

            int[] array = { 4, 5, 7, -3, 4, 3, -20, -1 };
            int[] window = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < window.Length; j++)
                {
                    window[j] = array[i+j];
                    
                    int minimum = window.Min();
                    int maximum = window.Max();
                    
                }
            }

            Console.ReadKey();
        }
    }
}
