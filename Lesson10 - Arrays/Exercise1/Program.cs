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
            string[] words1 = Console.ReadLine().Split(' ');
            string[] words2 = Console.ReadLine().Split(' ');

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < words1.Length && i < words2.Length; i++)
            {
                if (words1[i] == words2[i])
                {
                    countLeft++;
                }
                if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
                {
                    countRight++;
                }
            }

            Console.WriteLine(Math.Max(countLeft, countRight));
        }
    }
}
