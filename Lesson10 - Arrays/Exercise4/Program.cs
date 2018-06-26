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
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n+1];

            for (int i = 0; i <= n; i++)
            {
                arr[i] = true;
            }

            arr[0] = arr[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write("{0} ", i);
                    for (int j = i*i; j <= n; j += i)
                    {
                        arr[j] = false; 
                    }
                }
                
            }
            Console.WriteLine();

        }
    }
}
