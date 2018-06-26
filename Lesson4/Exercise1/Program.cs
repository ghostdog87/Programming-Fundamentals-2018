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
            
            string prod = Console.ReadLine();
            int q = int.Parse(Console.ReadLine());
            string result1;
            double result2;

            switch (prod)
            {
                case "Athlete":
                    result1 = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    result1 = "Coffee";
                    break;
                case "SoftUni Student":
                    result1 = "Beer";
                    break;
                default:
                    result1 = "Tea";
                    break;
            }

            switch (result1)
            {
                case "Water":
                    result2 = q * 0.70;
                    break;
                case "Coffee":
                    result2 = q * 1.00;
                    break;
                case "Beer":
                    result2 = q * 1.70;
                    break;
                default:
                    result2 = q * 1.20;
                    break;
            }

            Console.WriteLine("The {0} has to pay {1:f2}.",prod,result2);
        }
    }
}
