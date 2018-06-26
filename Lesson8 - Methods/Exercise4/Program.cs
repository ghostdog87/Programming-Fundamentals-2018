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
            string num = Console.ReadLine();
            Console.WriteLine(ReverseOrder(num));
        }
        static string ReverseOrder(string num)
        {
            string result = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += num[i];
            }
            return result;
        }

    }
}
