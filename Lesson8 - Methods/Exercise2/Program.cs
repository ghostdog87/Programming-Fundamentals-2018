using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (GetMax(a,b) > GetMax(a,c))
            {
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                Console.WriteLine(GetMax(a, c));
            }
        }
        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a < b)
            {
                max = b;
            }
            else
            {
                max = a;
            }
            return max;
        }
    }
}
