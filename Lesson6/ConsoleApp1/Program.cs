using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Console.ReadLine();
            int result = Convert.ToInt32(w, 16);
            Console.WriteLine(result);
        }
    }
}
