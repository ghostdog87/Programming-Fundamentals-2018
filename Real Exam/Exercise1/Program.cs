using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal moneyPerSaber = decimal.Parse(Console.ReadLine());
            decimal moneyPerRobe = decimal.Parse(Console.ReadLine());
            decimal moneyPerBelt = decimal.Parse(Console.ReadLine());

            int freeBelts = students / 6;
            decimal saberDiscount = Math.Ceiling((decimal)students / 10);

            decimal neededMoney = (moneyPerSaber * (students + saberDiscount)) + (moneyPerRobe * students) + (moneyPerBelt * (students - freeBelts));

            if (neededMoney<= money)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - money):f2}lv more.");
            }
        }
    }
}
