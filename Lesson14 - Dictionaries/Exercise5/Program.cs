using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Dictionary<string, List<string>>();
            string line;
            List<string> cards = new List<string>();

            while ((line = Console.ReadLine()) != "JOKER")
            {
                
                string name = line.Split(new char[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries)[0];
                string[] hands = line.Split(new string[] { ", ", ": " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

                cards = hands.Distinct().ToList();

                if (!player.ContainsKey(name))
                {
                    player.Add(name, cards);
                }
                else
                {
                    player[name].AddRange(cards);
                    player[name] = player[name].Distinct().ToList();
                }


            }

            foreach (var hands in player)
            {
                int sum = 0;
                foreach (var hand in hands.Value)
                {
                    sum += CardNum(hand.Substring(0, hand.Length - 1)) * Multiplier(hand.Last());
                }
                Console.WriteLine($"{hands.Key}: {sum}");
            }

        }

        static int CardNum(string card)
        {
            int cardIndex = 0;

            switch (card)
            {
                case "2":
                    cardIndex = 2;
                    break;
                case "3":
                    cardIndex = 3;
                    break;
                case "4":
                    cardIndex = 4;
                    break;
                case "5":
                    cardIndex = 5;
                    break;
                case "6":
                    cardIndex = 6;
                    break;
                case "7":
                    cardIndex = 7;
                    break;
                case "8":
                    cardIndex = 8;
                    break;
                case "9":
                    cardIndex = 9;
                    break;
                case "10":
                    cardIndex = 10;
                    break;
                case "J":
                    cardIndex = 11;
                    break;
                case "Q":
                    cardIndex = 12;
                    break;
                case "K":
                    cardIndex = 13;
                    break;
                case "A":
                    cardIndex = 14;
                    break;
                default:
                    break;
            }

            return cardIndex;
        }

        static int Multiplier(char color)
        {
            int multi = 1;
            switch (color)
            {
                
                case 'S':
                    multi = 4;
                    break;
                case 'H':
                    multi = 3;
                    break;
                case 'D':
                    multi = 2;
                    break;
                case 'C':
                    multi = 1;
                    break;
                default:
                    break;
            }
            return multi;
        }
    }
}
