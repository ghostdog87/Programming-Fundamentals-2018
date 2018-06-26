using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double result1 = LongerLine(x1, y1, x2, y2);
            double result2 = LongerLine(x3, y3, x4, y4);

            double tempX1 = 0;
            double tempY1 = 0;
            double tempX2 = 0;
            double tempY2 = 0;

            if (result1 >= result2)
            {
                tempX1 = x1;
                tempY1 = y1;
                tempX2 = x2;
                tempY2 = y2;
            }
            else
            {
                tempX1 = x3;
                tempY1 = y3;
                tempX2 = x4;
                tempY2 = y4;
            }
            if (CenterPoint(tempX1, tempY1) <= CenterPoint(tempX2, tempY2))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", tempX1, tempY1, tempX2, tempY2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", tempX2, tempY2, tempX1, tempY1);
            }
        }

        static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return result;
        }

        static double CenterPoint(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return result;
        }
    }
}
