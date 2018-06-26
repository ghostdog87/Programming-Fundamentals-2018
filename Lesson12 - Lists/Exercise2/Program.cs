using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToList();

            string stopCommand = "";

            while (true)
            {
                List<string> command = Console.ReadLine().Split(new char[] { ' ' }).ToList();

                if (command[0] == "Delete")
                {
                    while (numbers.Contains(int.Parse(command[1])))
                    {
                        numbers.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Odd" || command[0] == "Even")
                {
                    stopCommand = command[0];
                    break;
                }
            }

            foreach (var item in numbers)
            {
                if (stopCommand == "Even" && item % 2 == 0)
                {
                    Console.Write("{0} ",item);
                }
                else if (stopCommand == "Odd" && item % 2 != 0)
                {
                    Console.Write("{0} ", item);
                }
            }

            Console.WriteLine();
        }
    }
}
