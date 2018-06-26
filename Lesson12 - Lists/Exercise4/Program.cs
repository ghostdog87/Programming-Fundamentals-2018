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
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            List<int> result = new List<int>();

            int maxLength = 1;
            int bestEnd = 0;


            for (int i = 0; i < numbers.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (len[j] + 1 > len[i] && numbers[j] < numbers[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
                if (len[i] > maxLength)
                {
                    bestEnd = i;
                    maxLength = len[i];
                }
            }

            int previousIndex = bestEnd;
            result.Add(numbers[bestEnd]);

            while (true)
            {
                
                previousIndex = prev[previousIndex];
                if (previousIndex == -1)
                {
                    break;
                }
                int previousNum = numbers[previousIndex];
                result.Add(previousNum);
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
