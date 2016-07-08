using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputA = Console.ReadLine();
            var inputB = Console.ReadLine();

            char[] delimiter = { ' ', ',', '-' };
            string[] inputASplit = inputA.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            string[] inputBSplit = inputB.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] listA = new int[inputASplit.Length];
            int[] listB = new int[inputBSplit.Length];

            for (int i = 0; i < inputASplit.Length; i++)
            {
                listA[i] = int.Parse(inputASplit[i]);
            }

            for (int i = 0; i < inputBSplit.Length; i++)
            {
                listB[i] = int.Parse(inputBSplit[i]);
            }

            int[] concatinatedList = MergeSort(listA, listB);

            foreach (var number in concatinatedList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

        static int[] ParseListA(int[] ListA)
        {
            List<int> newListA = ListA.ToList();
            newListA.Sort();

            return newListA.ToArray();
                        
        }

        static int CountZeros(int[] ListB)
        {
            int zeroCount = 0;

            for (int i = 0; i < ListB.Length; i++)
            {
                if (ListB[i] == 0)
                {
                    zeroCount += 1;
                }
            }

            if (zeroCount == 0)
            {
                throw new Exception("List B doesn't contain any Zeroes.");
            }

            return zeroCount;
        }

        static int[] MergeSort(int[] listA, int[] listB)
        {
            int[] newListA = ParseListA(listA);
            int zeroCount = CountZeros(listB);
            int[] newListB = new int[listB.Length - zeroCount];

            if (newListA.Length != zeroCount)
            {
                throw new Exception("There weren't enough buffers!");
            } 

            for (int i = 0; i < listB.Length; i++)
            {
                if (listB[i] != 0)
                {
                    for (int j = 0; j < newListB.Length; j++)
                    {
                        newListB[j] = listB[i];
                    }
                }
            }

            int[] concatenatedList = newListA.Concat(newListB).ToArray();
            Array.Sort(concatenatedList);

            return concatenatedList;
        }
    }
}
