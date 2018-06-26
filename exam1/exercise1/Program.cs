using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());


            double ans1 = (a * 2 + b * 2);
            double ans2 = ans1 * price;
            double ans4 = ans1 * h;

            double ans3 = ans4 * weight;

            Console.WriteLine( ans1);
            Console.WriteLine("{0:0.00}", ans2);

            Console.WriteLine("{0:0.000}", ans3);
        }
    }
}
