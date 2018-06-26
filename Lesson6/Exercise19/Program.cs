using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = uint.Parse(Console.ReadLine());
            uint FT = uint.Parse(Console.ReadLine());
            byte FF = byte.Parse(Console.ReadLine());
            uint UT = uint.Parse(Console.ReadLine());

            double availPics = Math.Ceiling( N - (N - (N * FF / 100.0)));
            long filterPicsSeconds = (long)N * FT;
            long uploadPicsSeconds = (long)availPics * UT;
            long totalTime = filterPicsSeconds + uploadPicsSeconds;

            long seconds = (totalTime % 60);
            long minutes = (totalTime / 60);
            long hours = (minutes / 60);
            long days = (hours / 24);

            if (seconds >= 60)
            {
                seconds = seconds % 60;
            }
            if (minutes>=60)
            {
                minutes = minutes % 60;
            }
            if (hours>=24)
            {
                hours = hours % 24;
            }

            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);

        }
    }
}
