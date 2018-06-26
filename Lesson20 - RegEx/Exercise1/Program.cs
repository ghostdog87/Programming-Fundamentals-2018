using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([A-Za-z]+)([\._-]?)([\w\d]+)@([A-Za-z][A-Za-z-\.]+)([A-Za-z])\.([A-Za-z]+)";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine("{0}", m.Value);
            }
        }
    }
}
