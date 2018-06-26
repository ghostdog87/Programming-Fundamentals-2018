using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = 0;
            int bestLen = 1;

            int start = input[0];
            int len = 1;
            int bestPos = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > start)
                {
                    len++;
                    start = input[i];
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                        bestPos = i;
                    }
                }
                else
                {
                    len = 1;
                    start = input[i];
                }
            }

            List<int> output = new List<int>();

            for (int i = bestPos - bestLen + 1; i <= bestPos; i++)
            {
                output.Add(input[i]);
            }

            Console.WriteLine(string.Join(" ", output));

        }
    }
}
