using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int type = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            

            StringBuilder result = new StringBuilder();

            while (number > 0)
            {
                result.Append(number % type);
                number /= type; 
            }
            StringBuilder Reversedresult = new StringBuilder();

            for (int i = result.Length-1; i >= 0; i--)
            {
                Reversedresult.Append(result[i]);
            }

            Console.WriteLine(Reversedresult.ToString());
        }
    }
}
