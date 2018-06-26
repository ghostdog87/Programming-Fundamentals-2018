using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new Dictionary<string, Dictionary<string, long>>();
            

            string line;
            

            while ((line = Console.ReadLine()) != "report")
            {
                var city = new Dictionary<string, long>();

                string cityName = line.Split('|')[0];
                string countryName = line.Split('|')[1];
                long popul = long.Parse(line.Split('|')[2]);

                if (!country.ContainsKey(countryName))
                {
                    city.Add(cityName, popul);
                    country.Add(countryName, city);
                    
                }
                else
                {
                    country[countryName].Add(cityName, popul);
                }
            }

            foreach (var countryName in country.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{countryName.Key} (total population: {countryName.Value.Values.Sum()})");
                foreach (var city in countryName.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
            Console.WriteLine();

        }
    }
}
