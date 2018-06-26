using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (3 * n) + 6;
            int height = (3 * n) + 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
                
            }

            Console.WriteLine("{0}", new string('=', width - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (Math.Floor(n / 2.0) == i)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                }
                else
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', width - n - 2), new string(' ', n - 1));
                }
                
            }

            Console.WriteLine("{0}", new string('=', width - 1));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/", new string(' ', i - 1),new string('@',(width - n - i * 2)) );
            }

            Console.WriteLine("{0}", new string('=', width - n));
        }
    }
}
