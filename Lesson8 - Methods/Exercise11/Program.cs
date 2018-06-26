using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            Console.WriteLine("{0:f2}",GeoCalc(shape));
        }
        static double GeoCalc(string shape)
        {
            double result = 0;

            switch (shape)
            {
                case "triangle":
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    result = (a * b) / 2;
                    break;
                case "square":
                    double c = double.Parse(Console.ReadLine());
                    result = c * c;
                    break;
                case "rectangle":
                    double d = double.Parse(Console.ReadLine());
                    double e = double.Parse(Console.ReadLine());
                    result = d * e;
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    result = Math.PI * Math.Pow(r,2);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
