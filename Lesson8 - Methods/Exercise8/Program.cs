using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (CenterPoint(x1,y1) <= CenterPoint(x2, y2))
            {
                Console.WriteLine("({0}, {1})",x1,y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }

        static double CenterPoint(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
            return result;
        }
    }
}
