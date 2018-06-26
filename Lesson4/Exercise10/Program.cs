using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < i+1; a++)
                {
                    Console.Write("{0} ",i+1);
                }
                Console.WriteLine();
            }

        }
    }
}
