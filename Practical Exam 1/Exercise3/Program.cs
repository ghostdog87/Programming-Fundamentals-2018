using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] drivers = Console.ReadLine().Split(' ');

            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            

            for (int a = 0; a < drivers.Length; a++)
            {
                double playerFuel = drivers[a].First();

                for (int c = 0; c < zones.Length; c++)
                {
                    if (checkpoints.Contains(c))
                    {
                        playerFuel += zones[c];
                    }
                    else
                    {
                        playerFuel -= zones[c];
                        if (playerFuel<=0)
                        {
                            Console.WriteLine($"{drivers[a]} - reached {c}");

                            break;
                        }
                    }
                    
                }

                if (playerFuel>0)
                {
                    Console.WriteLine($"{drivers[a]} - fuel left {playerFuel:f2}");
                }
                
            }


        }
    }
}
