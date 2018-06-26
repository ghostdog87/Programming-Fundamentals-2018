using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double result1 = (double)(energy * volume) / 100;
            double result2 = (double)(sugar * volume) / 100;

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume,name, result1, result2);
        }
    }
}
