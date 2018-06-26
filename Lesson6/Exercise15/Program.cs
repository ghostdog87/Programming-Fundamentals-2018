using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool flag = true;
                for (int b = 2; b <= Math.Sqrt(i); b++)
                {
                    if (i % b == 0)
                    {
                        flag = false;
                        
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {flag}");

            }
        }
    }
}
