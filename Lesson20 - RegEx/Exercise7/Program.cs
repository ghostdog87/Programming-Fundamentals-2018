using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();

                if (input== "END")
                {
                    break;
                }

                input = input.Replace("+"," ");
                input = input.Replace("%20", " ");
                string[] keyValuePair = input.Split(new char[] { '&', '?' },StringSplitOptions.RemoveEmptyEntries).ToArray();

                string pattern = @"(.*)[=](.*)";
                for (int i = 0; i < keyValuePair.Length; i++)
                {

                    List<string> values = new List<string>();
                    foreach (Match match in Regex.Matches(keyValuePair[i], pattern))
                    {
                        string currentKey = match.Value.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                        string currentValue = match.Value.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();

                        string pattern2 = @"\s{2,}";

                        currentKey = Regex.Replace(currentKey, pattern2, " ");
                        currentValue = Regex.Replace(currentValue, pattern2, " ");

                        if (!result.ContainsKey(currentKey))
                        {
                            values.Add(currentValue);
                            result.Add(currentKey, values);
                        }
                        else
                        { 
                            result[currentKey].Add(currentValue);
                        }
                    }
                }
                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=["+ string.Join(", ",item.Value) + "]");
                }
                Console.WriteLine();
            }
          
        }
    }
}
