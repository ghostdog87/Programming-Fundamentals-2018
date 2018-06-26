using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            string pattern = @"(\b)([A-Za-z][\w]+)";

            List<string> usernames = new List<string>();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                if (m.Length >= 3 && m.Length <= 25)
                {
                    usernames.Add(m.ToString().Trim());
                }
                
            }

            int counterMax = 0;
            List<string> result = new List<string>();

            for (int a = 0; a < usernames.Count-1; a++)
            {
                if ((usernames[a].Length + usernames[a+1].Length) > counterMax)
                {
                    counterMax = usernames[a].Length + usernames[a + 1].Length;
                    result.Clear();
                    result.Add(usernames[a]);
                    result.Add(usernames[a + 1]);
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
