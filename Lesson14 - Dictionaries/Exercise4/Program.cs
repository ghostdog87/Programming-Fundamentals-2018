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
            var resource = new Dictionary<string, string>();

            string token;

            while ((token = Console.ReadLine()) != "stop")
            {
                string name = token;
                string email = Console.ReadLine();

                if (!email.EndsWith(".us") && !email.EndsWith(".uk"))
                {
                    resource[name] = email;
                }
            }

            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
