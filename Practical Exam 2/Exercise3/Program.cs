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
            List<string> demons = new List<string>();

            string[] demonNames = Console.ReadLine().Trim().Split(new char[] { ' ', ',','\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < demonNames.Length; i++)
            {
                decimal health = 0;
                decimal dmg = 0;

                string healthPattern = @"[^0-9\+\-\*\/\.]";
                string digitsPattern = @"([\-\+]?[0-9]+[0-9\.0-9]*)";
                string nonDigitsPattern = @"([\*\/])";

                MatchCollection healthMatches = Regex.Matches(demonNames[i].Trim(), healthPattern);
                MatchCollection digitMatches = Regex.Matches(demonNames[i].Trim(), digitsPattern);
                MatchCollection nonDigitMatches = Regex.Matches(demonNames[i].Trim(), nonDigitsPattern);

                for (int a = 0; a < healthMatches.Count; a++)
                {
                    health += healthMatches[a].Value.ToCharArray()[0];
                }

                foreach (Match item in digitMatches)
                {
                    dmg += decimal.Parse(item.ToString());
                }

                foreach (Match item in nonDigitMatches)
                {
                    switch (item.ToString())
                    {
                        case "*":
                            dmg *= 2;
                            break;
                        case "/":
                            dmg /= 2;
                            break;
                        default:
                            break;
                    }
                }

                demons.Add($"{demonNames[i]} - {health} health, {dmg:f2} damage");
            }

            foreach (var demon in demons.OrderBy(x=>x))
            {
                Console.WriteLine(demon);
            }
        }
    }
}
