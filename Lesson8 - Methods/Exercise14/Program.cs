using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fakt = 1;
            for (int i = 1; i <= n; i++)
            {
                fakt *= i;
            }
            int counter = 0;
            while (fakt % 10 == 0)
            {
                fakt /= 10;
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
