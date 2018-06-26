using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }
        static int Fib(int n)
        {

            int num1 = 0;
            int num2 = 1;
            int result = 0;

            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }
            }
            else
            {
                result = 1;
            }

            return result;
        }
    }
}
