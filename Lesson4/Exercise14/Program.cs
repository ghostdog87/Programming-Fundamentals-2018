using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            for (char i = letter1; i <= letter2; i++)
            {
                for (char b = letter1; b <= letter2; b++)
                {
                    for (char c = letter1; c <= letter2; c++)
                    {
                        if (i != letter3 && b != letter3 && c != letter3)
                        {
                            Console.Write($"{i}{b}{c} ");
                        }
                    }

                }
            }
        }
    }
}
