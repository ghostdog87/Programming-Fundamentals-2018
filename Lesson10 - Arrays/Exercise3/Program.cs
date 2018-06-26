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
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] middleNumbers = new int[k * 2];
            int[] leftNumbers = new int[k];
            int[] rightNumbers = new int[k];

            middleNumbers = input.Skip(k).Take(k * 2).ToArray();
            leftNumbers = input.Take(k).ToArray();
            rightNumbers = input.Skip(k*3).Take(k).ToArray();

            Array.Reverse(leftNumbers);
            Array.Reverse(rightNumbers);

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = middleNumbers[i] + leftNumbers[i];
                result[i+k] = middleNumbers[i+k] + rightNumbers[i];
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
