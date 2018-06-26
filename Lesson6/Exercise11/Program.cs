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
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float miles = ConvertToMiles(meters);
            float timeInSeconds = ConvertToSeconds(hours, minutes, seconds);
            float timeInHours = ConvertToHours(hours, minutes, seconds);
            float km = ConvertToKm(meters);
            Console.WriteLine(meters / timeInSeconds);
            Console.WriteLine(km / timeInHours);
            Console.WriteLine(miles / timeInHours);
        }
        static float ConvertToKm(int meters)
        {
            float km = meters / 1000f;
            return km;
        }
        static float ConvertToMiles(int meters)
        {
            float miles = meters / 1609f;
            return miles;
        }
        static float ConvertToSeconds(int hours, int minutes, int seconds)
        {
            return (hours * 60f * 60f) + (minutes * 60f) + seconds; 
        }
        static float ConvertToHours(float hours, float minutes, float seconds)
        {
            return hours + (minutes / 60) + (seconds / 3600);
        }
    }
}
