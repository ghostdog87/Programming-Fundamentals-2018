using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if ("aeiouAEIOU".IndexOf(word) >= 0)
            {
                Console.WriteLine("vowel");
            }
            else if (int.TryParse(word,out int num) && (num >=0 && num<=9))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
