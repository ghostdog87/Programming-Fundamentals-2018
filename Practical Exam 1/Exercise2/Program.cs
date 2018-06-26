using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            string[] participants = Console.ReadLine().Split(new char[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();


            while (true)
            {
                string currentPerformance = Console.ReadLine();
                List<string> awards = new List<string>();

                if (currentPerformance == "dawn")
                {
                    break;
                }
              
                string participant = currentPerformance.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                string song = currentPerformance.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                string award = currentPerformance.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)[2].Trim();

                if (!songs.Contains(song))
                {
                    continue;
                }

                if (!participants.Contains(participant))
                {
                    continue;
                }

                if (!result.ContainsKey(participant))
                {
                    awards.Add(award);
                    result.Add(participant, awards);
                }
                else
                {
                    if (!result[participant].Contains(award))
                    {
                        
                        result[participant].Add(award);
                    }
                }

            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var player in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Count} awards");

                foreach (var awards in player.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"--{awards}");
                }
            }
        }
    }
}
