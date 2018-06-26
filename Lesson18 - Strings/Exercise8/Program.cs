using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i].Trim();
                decimal currentResult = 0;

                string pattern = @"([A-Za-z])(\d+)([A-Za-z])";
                Match groups = Regex.Match(input[i], pattern);
                

                bool isFirstLetterUpper = groups.Groups[1].Value.ToCharArray()[0] < 91 ? true : false;
                decimal firstLetter = groups.Groups[1].Value.ToCharArray()[0] < 91 ? groups.Groups[1].Value.ToCharArray()[0] - 64 : groups.Groups[1].Value.ToCharArray()[0] - 96;
                bool isSecondLetterUpper = groups.Groups[3].Value.ToCharArray()[0] < 91 ? true : false;
                decimal SecondLetter = groups.Groups[3].Value.ToCharArray()[0] < 91 ? groups.Groups[3].Value.ToCharArray()[0] - 64 : groups.Groups[3].Value.ToCharArray()[0] - 96;
                decimal currentNum = decimal.Parse(groups.Groups[2].Value.ToString());

                if (isFirstLetterUpper)
                {
                    currentResult = currentNum / firstLetter;
                }
                else
                {
                    currentResult = currentNum * firstLetter;
                }

                if (isSecondLetterUpper)
                {
                    currentResult = currentResult - SecondLetter;
                }
                else
                {
                    currentResult = currentResult + SecondLetter;
                }


                result += currentResult;
            }

            

            Console.WriteLine($"{result:f2}");
        }
    }
}
