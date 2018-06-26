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
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> result = IsPrime(start, end);

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
                if (i < result.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            
        }

        static List<int> IsPrime(int start, int end)
        {
            List<int> result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                result.Add(i);
            }

            for (int a = start; a <= end; a++)
            {
                if (a < 2)
                {
                    result.Remove(a);
                }

                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        result.Remove(a);
                        break;
                    }
                }
            }


            return result;
        }
    }
}
