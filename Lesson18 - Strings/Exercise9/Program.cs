using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (true)
            {
                if (input.IndexOf(pattern) >= 0 && (input.IndexOf(pattern) != input.LastIndexOf(pattern)))
                {
                    input = input.Remove(input.IndexOf(pattern), pattern.Length);
                    input = input.Remove(input.LastIndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }

                if (pattern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
