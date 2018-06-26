using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lut = double.Parse(Console.ReadLine());
            int box = int.Parse(Console.ReadLine());
            int jar = int.Parse(Console.ReadLine());

            double kilo = lut / 5.0;
            double burks = kilo / 0.535;
            double kaset = burks / jar;

            Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor( kilo));

            if (kaset > box)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(kaset - box));
                Console.WriteLine("{0} jars left.", Math.Floor(burks - (box * jar)));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(Math.Abs( box - kaset)));
                Console.WriteLine("{0} more jars needed.", Math.Floor(Math.Abs((box * jar) - burks)));
            }


        }
    }
}
