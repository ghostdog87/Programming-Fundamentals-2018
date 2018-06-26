using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int tempA = b;
            int tempB = a;
            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}",a,b,tempA,tempB);
        }
    }
}
