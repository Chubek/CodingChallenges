using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            char[] seperator = { ' ' };
            int iterationFactor = 0;

            string[] commandSplit = command.Split(seperator);

            if (!(commandSplit[0] == "print"))
                throw new Exception("Command must start with print");
            else if (!(int.TryParse(commandSplit[1], out iterationFactor)))
                throw new Exception("Iteration factor invalid");
            else if (!(commandSplit.Length == 3))
                throw new Exception("Syntax error");

            for (int i = 0; i < iterationFactor; i++)
            {
                Console.WriteLine(commandSplit[2]);
            }

            Console.ReadKey();
        }
    }
}
