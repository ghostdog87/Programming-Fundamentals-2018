using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            for (int i = 0; i < n; i++)
            {
                var ans = double.Parse(Console.ReadLine());
                if (ans >= 0 && ans <= 22.5) count1++;
                if (ans > 22.5 && ans <= 40.5) count2++;
                if (ans > 40.5 && ans <= 58.5) count3++;
                if (ans > 58.5 && ans <= 76.5) count4++;
                if (ans > 76.5 && ans <= 100) count5++;
            }

            Console.WriteLine("{0:N2}% poor marks", 100.0 / n * count1);
            Console.WriteLine("{0:N2}% satisfactory marks", 100.0 / n * count2);
            Console.WriteLine("{0:N2}% good marks", 100.0 / n * count3);
            Console.WriteLine("{0:N2}% very good marks", 100.0 / n * count4);
            Console.WriteLine("{0:N2}% excellent marks", 100.0 / n * count5);
        }
    }
}
