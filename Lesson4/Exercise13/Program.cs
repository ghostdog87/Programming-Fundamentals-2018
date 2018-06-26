using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int magicN = 0;
            int magicM = 0;
            int count = 0;
            bool flag = false;

            for (int i = n; i <= m; i++)
            {
                for (int b = n; b <= m; b++)
                {
                    count++;
                    if (i + b == magicNum)
                    {
                        magicN = i;
                        magicM = b;
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine($"Number found! {magicN} + {magicM} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
