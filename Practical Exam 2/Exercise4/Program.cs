using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> events = new Dictionary<string,string>();

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Time for Code")
                {
                    break;
                }

                string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string currentID = input[0];
                string eventName = input[1];
                List<string> participants = input.Skip(2).Distinct().ToList();

                if (eventName[0] != '#') // invalid hashtag
                {
                    continue;
                }

                Dictionary<string, List<string>> currentEvent = new Dictionary<string, List<string>>();

                if (!events.ContainsKey(currentID))
                {
                    currentEvent.Add(eventName, participants);
                    result.Add(eventName, participants);
                    events.Add(currentID, eventName);
                    
                }
                else
                {
                    if (!events[currentID].Contains(eventName))
                    {
                        continue;
                    }
                    else
                    {
                        result[eventName].AddRange(participants);
                        result[eventName] = result[eventName].Distinct().ToList();
                    }
                }
            }

            foreach (var item in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key.TrimStart('#')} - {item.Value.Count}");
                foreach (var player in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"{player}");
                }
            }
        }
    }
}
