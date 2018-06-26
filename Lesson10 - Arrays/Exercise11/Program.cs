using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestPos = 0;
            bool flag = false;

            for (int a = 0; a < input.Length; a++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int b = 0; b < a; b++)
                {
                    sumLeft += input[b];
                }
                for (int c = a + 1; c < input.Length; c++)
                {
                    sumRight += input[c];
                }
                if (sumLeft == sumRight)
                {
                    flag = true;
                    bestPos = a;
                }
            }

            if (flag)
            {
                Console.WriteLine(bestPos);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
