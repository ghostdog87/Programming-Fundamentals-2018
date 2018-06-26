using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();

            string token;
            int counter = 0;
            string resourceName = "";
            int resourceValue;

            while ((token = Console.ReadLine()) != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    resourceName = token;                   
                }
                else
                {
                    resourceValue = int.Parse(token);

                    if (resource.ContainsKey(resourceName))
                    {
                        resource[resourceName] += resourceValue;
                    }
                    else
                    {
                        resource[resourceName] = resourceValue;
                    }
                    
                }

            }

            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
