using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = input[0];
            int n = input[1];

            string text = Console.ReadLine();

            string pattern = @"[|][<]+[\w]+";

            List<string> result = new List<string>();

            foreach (Match match in Regex.Matches(text, pattern))
            {
                int tempN = n;

                string currentText = match.Value.TrimStart('|', '<');
                if (m + n > currentText.Length)
                {
                    tempN = currentText.Length - m;
                }

                result.Add(currentText.Substring(m, tempN));
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
