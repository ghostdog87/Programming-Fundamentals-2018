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
            int count = 0;
            while (true)
            {
                try
                {
                    int word = int.Parse(Console.ReadLine());
                }
                catch
                {
                    break;
                }

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
