using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string word = Console.ReadLine();
            string[] input = Console.ReadLine().Split(new char[] { '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"(\b){word}(\b)";


            foreach (var sentence in input)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
                
            }
        }
    }
}
