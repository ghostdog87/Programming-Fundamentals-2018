using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string pattern = @"[starSTAR]";
            List<string> destroyedPlanets = new List<string>();
            List<string> attackedPlanets = new List<string>();

            while (n>0)
            {
                n--;
                string currentText = Console.ReadLine();

                int counter = 0;

                foreach (Match match in Regex.Matches(currentText, pattern))
                {
                    counter++;
                }

                string decryptedText = string.Empty;

                foreach (var symbol in currentText)
                {
                    decryptedText += (char)(symbol - counter);
                }

                string planetPattern = @"(@)([^A-Za-z]*)([A-Za-z]+)([^A-Za-z]*):";
                string EventPattern = @"!.+!";

                string validate = @"(@){1}([^A-Za-z]*)([A-Za-z]+)([^A-Za-z]*)(:){1}([^\d]*)([\d]+)([^\d]*)(![AD]{1}!)(->){1}([^\d]*)([\d]+)([^\d]*)";


                //if ()
                if(!Regex.Match(decryptedText, validate).Success)
                {
                    continue;
                }


                Match events = Regex.Match(decryptedText, EventPattern);
                Match name = Regex.Match(decryptedText, planetPattern);

                if (events.Value.Contains("A"))
                {
                    attackedPlanets.Add(name.Groups[3].Value.TrimStart('@').TrimEnd(':'));
                }
                else
                {
                    destroyedPlanets.Add(name.Groups[3].Value.TrimStart('@').TrimEnd(':'));
                }

            }


            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

        }
    }
}
