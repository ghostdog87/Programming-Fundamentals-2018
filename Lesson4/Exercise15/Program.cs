using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int dmgPlayer1 = int.Parse(Console.ReadLine());
            int dmgPlayer2 = int.Parse(Console.ReadLine());

            int rounds = 0;

            int hpPlayer1 = 100;
            int hpPlayer2 = 100;

            while (hpPlayer1 > 0 && hpPlayer2 > 0)
            {
                
                hpPlayer2 -= dmgPlayer1;
                rounds++;
                if (hpPlayer2 < 1)
                {
                    Console.WriteLine("Pesho won in {0}th round.", rounds);
                    break;
                }
                else
                {
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", hpPlayer2);
                }

                if (rounds % 3 == 0)
                {
                    hpPlayer2 += 10;
                    hpPlayer1 += 10;
                }

                hpPlayer1 -= dmgPlayer2;
                rounds++;
                if (hpPlayer1 < 1)
                {
                    Console.WriteLine("Gosho won in {0}th round.", rounds);
                    break;
                }
                else
                {
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", hpPlayer1);
                }
                if (rounds % 3 == 0)
                {
                    hpPlayer2 += 10;
                    hpPlayer1 += 10;
                }
            }
        }
    }
}
