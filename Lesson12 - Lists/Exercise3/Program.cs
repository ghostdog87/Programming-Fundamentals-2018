using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = commands[0]; i < numbers.Count; i++)
            {
                numbers.RemoveAt(i);
            }

            numbers.RemoveRange(0, commands[1]);

            if (numbers.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
