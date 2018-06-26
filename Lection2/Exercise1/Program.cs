using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "";

            for (int i = 0; i < 4; i++)
            {
                int a = int.Parse( Console.ReadLine());
                if (i > 0) { result = result + " "; }
                result = result + $"{ a:D4}";
                
            }
            Console.WriteLine(result);
        }
    }
}
