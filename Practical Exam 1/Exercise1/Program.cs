using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            long steps = long.Parse(Console.ReadLine());
            long timePerStep = long.Parse(Console.ReadLine());

            long timeSpend = steps * timePerStep;

            long[] currentTime = time.Split(':').Select(long.Parse).ToArray();

            long currentHours = currentTime[0];
            long currentMinutes = currentTime[1];
            long currentSeconds = currentTime[2];

            long newSeconds = 0;
            long newMinutes = 0;
            long newHours = 0;

            newSeconds = currentSeconds + timeSpend;
            if (newSeconds > 59)
            {
                newMinutes = newSeconds / 60;
                newSeconds = newSeconds % 60;
                
            }
            newMinutes += currentMinutes;
            if (newMinutes > 59)
            {
                newHours = newMinutes / 60;
                newMinutes = newMinutes % 60;
                
            }
            newHours += currentHours;
            if (newHours > 23)
            {
                newHours = newHours % 24;
            }
            Console.WriteLine($"Time Arrival: {newHours:d2}:{newMinutes:d2}:{newSeconds:d2}");
        }
    }
}
