using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, int>();

            var logs = new Dictionary<string, List<string>>();

            

            for (int i = 0; i < n; i++)
            {

                var IPs = new List<string>();

                string[] line = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currentIP = line[0];
                string username = line[1];
                int duration = int.Parse(line[2]);

                

                if (!users.ContainsKey(username))
                {
                    IPs.Add(currentIP);
                    logs.Add(username, IPs);
                    users.Add(username, duration);
                }
                else
                {
                    IPs.AddRange(logs[username].ToList());

                    if (!logs[username].Contains(currentIP))
                    {
                        IPs.Add(currentIP);
                        duration += users[username];
                        logs[username] = IPs;
                        users[username] = duration;
                    }
                    else
                    {
                        duration += users[username];
                        logs[username] = IPs;
                        users[username] = duration;
                    }
                }
                
            }

            

            foreach (var user in users.OrderBy(x => x.Key))
            {
                List<string> IPs = new List<string>();
                
                Console.Write($"{user.Key}: {user.Value} ");
                foreach (var log in logs[user.Key])
                {
                    IPs.Add(log);
                }
                IPs.Sort();
                Console.WriteLine("["+ string.Join(", ",IPs) +"]");
            }
        }
    }
}
