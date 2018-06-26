using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int type = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);


            BigInteger result = 0;
            int i = 0;

            while (number > 0)
            {
                BigInteger lastNum = (number % 10);

                result = result + (lastNum * BigInteger.Pow(type, i));

                number /= 10;
                i++;
            }

            Console.WriteLine(result);
        }
    }
}
