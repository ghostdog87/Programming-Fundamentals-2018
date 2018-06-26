using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();


            if (multiplier == 0)
            {
                Console.WriteLine(0);

                return;
            }

            int remainder = 0;

            for (int i = Num.Length - 1; i >= 0; i--)
            {
                    int currentResult = (int.Parse(Num[i].ToString()) * multiplier) + remainder;
                    result.Append(currentResult % 10);
                    remainder = Remainder(currentResult);

            }

            if (remainder > 0)
            {
                result.Append(remainder);
            }

            string end = string.Concat(result.ToString().Reverse());

            Console.WriteLine(end);
        }

        static int Remainder(int currentResult)
        {
            if (currentResult > 9)
            {
                return currentResult / 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
