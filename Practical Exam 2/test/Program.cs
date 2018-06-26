using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Coffee_Orders_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0.0m;
            List<decimal> sums = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);
                decimal capsules = decimal.Parse(Console.ReadLine());
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);

                decimal sum = (daysInMonth * capsules) * pricePerCapsule;
                totalSum += sum;

                sums.Add(sum);
            }
            foreach (var item in sums)
            {
                Console.WriteLine("The price for the coffee is: ${0:f2}", item);
            }
            Console.WriteLine("Total: ${0:f2}", totalSum);
        }
    }
}