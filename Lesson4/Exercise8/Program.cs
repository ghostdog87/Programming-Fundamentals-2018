using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string prod = Console.ReadLine();
                if (prod.ToLower() == "cheese")
                {
                    count = count + 500;
                }
                else if (prod.ToLower() == "tomato sauce")
                {
                    count = count + 150;
                }
                else if (prod.ToLower() == "salami")
                {
                    count = count + 600;
                }
                else if (prod.ToLower() == "pepper")
                {
                    count = count + 50;
                }
                else
                {
                    count = count + 0;
                }
            }

            Console.WriteLine("Total calories: {0}",count);
        }
    }
}
