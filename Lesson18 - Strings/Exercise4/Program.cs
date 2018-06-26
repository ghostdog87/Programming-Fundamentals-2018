using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];

            int shorterString = input.Min(x => x.Length);
            int longerString = input.Max(x => x.Length);


            BigInteger result = new BigInteger();

            for (int i = 0; i < shorterString; i++)
            {
                result += firstString[i] * secondString[i];
            }

            if (firstString.Length == shorterString)
            {
                for (int i = shorterString; i < longerString; i++)
                {
                    result += secondString[i];
                }
            }
            else
            {
                for (int i = shorterString; i < longerString; i++)
                {
                    result += firstString[i];
                }
            }            

            Console.WriteLine(result);
        }
    }
}
