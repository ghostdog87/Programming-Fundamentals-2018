using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string prop = Console.ReadLine();

            Console.WriteLine("{0:F2}",CudeProperties(n,prop));
        }

        static double CudeProperties(double n, string prop)
        {
            if (prop == "face")
            {
                return Math.Sqrt(2 * Math.Pow(n, 2));
            }
            else if (prop == "space")
            {
                return Math.Sqrt(3 * Math.Pow(n, 2));
            }
            else if (prop == "volume")
            {
                return Math.Pow(n, 3);
            }
            else
            {
                return 6 * Math.Pow(n, 2);
            }
        }


    }
}
