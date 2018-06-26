using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {


                result.Append("\\u" + ((int)input[i]).ToString("X4").ToLower());
            }

            Console.WriteLine(result);
        }
    }
}
