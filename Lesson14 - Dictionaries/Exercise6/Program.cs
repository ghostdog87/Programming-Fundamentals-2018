using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            

            string line;

            while ((line = Console.ReadLine()) != "end")
            {
                string username = line.Split(new string[] {"user="}, StringSplitOptions.RemoveEmptyEntries)[1];
                string ip = line.Split(new string[] { "IP="," message=" }, StringSplitOptions.RemoveEmptyEntries)[0];
                Dictionary<string, int> address = new Dictionary<string, int>();

                if (!users.ContainsKey(username) )
                {
                    address.Add(ip, 1);
                    users.Add(username, address);
                }
                else
                {
                    if (!users[username].ContainsKey(ip))
                    {                       
                        users[username].Add(ip,1);
                    }
                    else
                    {
                        users[username][ip]++;
                    }
                }
            }
          
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: ");
                List<string> result = new List<string>();
                foreach (var item in user.Value)
                {
                    result.Add($"{item.Key} => {item.Value}");
                    
                }
                Console.Write(string.Join(", ", result) + ".");
                Console.WriteLine();
            }
        }
    }
}
