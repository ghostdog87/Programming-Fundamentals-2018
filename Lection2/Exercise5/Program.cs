using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currentEn = int.Parse(Console.ReadLine());
            int maxEn = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |" + new string('|', currentHP) + new string('.', maxHP - currentHP) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEn) + new string('.', maxEn - currentEn) + "|");
        }
    }
}
