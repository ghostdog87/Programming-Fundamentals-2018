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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i <= Math.Abs(a - b); i++)
            {
                if (a < b)
                {
                    Console.WriteLine(a + i);
                }
                else
                {
                    Console.WriteLine(b + i);
                }
            }
        }
    }
}
