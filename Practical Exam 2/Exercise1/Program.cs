using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            BigInteger runners = int.Parse(Console.ReadLine());
            BigInteger laps = int.Parse(Console.ReadLine());
            BigInteger lapLength = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());


            BigInteger realRunners = capacity * days;
            if (realRunners > runners)
            {
                realRunners = runners;
            }

            BigInteger totalMeters = realRunners * laps * lapLength;
            BigInteger totalKilometers = totalMeters / 1000;

            decimal result = (decimal)totalKilometers * money;

            Console.WriteLine($"Money raised: {result:f2}");
        }
    }
}
