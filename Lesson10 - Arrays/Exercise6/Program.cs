using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
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

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == start)
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }                   
                }
                else
                {
                    len = 1;
                    start = input[i];
                }
            }

            List<int> output = new List<int>();

            for (int i = 0; i < bestLen; i++)
            {
                output.Add(bestStart);
            }

            Console.WriteLine(string.Join(" ",output));

        }
    }
}
