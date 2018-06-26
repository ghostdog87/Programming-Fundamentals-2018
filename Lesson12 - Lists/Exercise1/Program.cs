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
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToList();

            int bestStart = numbers[0];
            int bestLen = 1;

            for (int a = 0; a < numbers.Count; a++)
            {
                int len = 0;
                int start = numbers[a];

                for (int b = 0; b < numbers.Count; b++)
                {
                    if (start == numbers[b])
                    {
                        len++;
                        if (len > bestLen)
                        {
                            bestLen = len;
                            bestStart = start;
                        }
                    }
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < bestLen; i++)
            {
                result.Add(bestStart);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
