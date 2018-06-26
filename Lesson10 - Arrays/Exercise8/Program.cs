using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = input[0];
            int bestLen = 0;

            int len = 0;

            for (int a = 0; a < input.Length; a++)
            {
                
                for (int b = 0; b < input.Length; b++)
                {
                    if (input[a] == input[b])
                    {
                        len++;
                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = input[b];
                        }
                    }
                    else
                    {
                        len = 0;
                    }
                }
            }

            Console.WriteLine(bestStart);
        }
    }
}
