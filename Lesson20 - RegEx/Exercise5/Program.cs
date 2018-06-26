using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();

            string patternKeys = @"([A-Za-z]+)[\|<\\]\w+[\|<\\]([A-Za-z]+)";

            string startKey = string.Empty;
            string endKey = string.Empty;

            foreach (Match match in Regex.Matches(keys, patternKeys))
            {
                startKey = match.Groups[1].Value;
                endKey = match.Groups[2].Value;
            }
            string patternText = $@"({startKey})(.*?)({endKey})";

            string result = string.Empty;

            foreach (Match match in Regex.Matches(text, patternText))
            {
                result += match.Groups[2].Value;
            }

            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
            

        }
    }
}
