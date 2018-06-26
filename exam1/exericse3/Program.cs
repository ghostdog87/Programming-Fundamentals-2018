using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (type == "standard")
            {
                if (weight < 1) price = 0.03 * km;
                if (weight >= 1 && weight <= 10) price = 0.05 * km;
                if (weight >= 11 && weight <= 40) price = 0.10 * km;
                if (weight >= 41 && weight <= 90) price = 0.15 * km;
                if (weight >= 91 && weight <= 150) price = 0.20 * km;
            }
            else
            {
                if (weight < 1) price = (0.03 *  km) + (0.03 * 0.80 * weight * km);
                if (weight >= 1 && weight <= 10) price = (0.05 * km) + (0.05 * 0.40 * weight * km);
                if (weight >= 11 && weight <= 40) price = (0.10 * km) + (0.10 * 0.05 * weight * km);
                if (weight >= 41 && weight <= 90) price = (0.15 * km) + (0.15 * 0.02 * weight * km);
                if (weight >= 91 && weight <= 150) price = (0.20 * km) + (0.20 * 0.01 * weight * km); ;
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:N3} kg. would cost {1:N2} lv.",weight,price);

        }
    }
}
