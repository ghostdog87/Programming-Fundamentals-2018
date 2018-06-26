using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse( Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}",w*h);
        }
    }
}
