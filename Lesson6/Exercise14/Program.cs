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
            int num = int.Parse(Console.ReadLine());
            string result1 = Convert.ToString(num, 16).ToUpper();
            string result2 = Convert.ToString(num, 2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
