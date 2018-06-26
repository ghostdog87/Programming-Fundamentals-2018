using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
               
                string pattern = @"([A-Z]{2})([\d]+.[\d]+)([A-Za-z]+)(?=\|)";

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    List<string> currentWeather = new List<string>();
                    string city = match.Groups[1].Value;

                    currentWeather.Add(match.Groups[2].Value);
                    currentWeather.Add(match.Groups[3].Value);

                    if (!result.ContainsKey(city))
                    {
                        result.Add(city, currentWeather);
                    }
                    else
                    {
                        result[city] = currentWeather;
                    }
                }

            }

            foreach (var city in result.OrderBy(x=>x.Value[0]))
            {
                double temp = double.Parse(city.Value[0]);
                Console.WriteLine($"{city.Key} => {temp:f2} => {city.Value[1]}");
            }
        }
    }
}
