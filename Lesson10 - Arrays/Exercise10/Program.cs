using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int count = 0;

            for (int a = 0; a < input.Length; a++)
            {
                for (int b = a + 1; b < input.Length; b++)
                {
                    if (Math.Abs(input[a] - input[b]) == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
