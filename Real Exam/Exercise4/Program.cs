using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input== "Lumpawaroo")
                {
                    break;
                }
                
                if (input.Contains('|'))
                {
                    string[] currentUser = input.Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
                    string side = currentUser[0].Trim();
                    string username = currentUser[1].Trim();

                    List<string> UsersPerSide = new List<string>();


                    if (users.Values.Any(v => v.Any(s => s == username)))
                    {
                        //users.Values.Any(v => v.Remove(username));
                        continue;
                    }

                    if (!users.ContainsKey(side))
                    {
                        UsersPerSide.Add(username);
                        users.Add(side, UsersPerSide);
                    }
                    else
                    {
                        if (!users[side].Contains(username))
                        {
                            users[side].Add(username);
                        }
                    }                  
                }

                if (input.Contains("->"))
                {
                    string[] currentUser = input.Split(new char[] { '-','>'}, StringSplitOptions.RemoveEmptyEntries);
                    string username = currentUser[0].Trim();
                    string side = currentUser[1].Trim();
 
                    if (!users.ContainsKey(side))
                    {
                        //UsersPerSide.Add(username);
                        //users.Add(side, UsersPerSide);
                        continue;
                    }
                    else
                    {
                        if (!users[side].Contains(username))
                        {
                            if (users.Values.Any(v => v.Any(s => s == username)))
                            {
                                users.Values.Any(v => v.Remove(username));
                                users[side].Add(username);
                                Console.WriteLine($"{username} joins the {side} side!");
                            }
                            else
                            {
                                users[side].Add(username);
                                Console.WriteLine($"{username} joins the {side} side!");
                            }
                            
                        }
                    }
                }
            }


            foreach (var djedi in users.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key).Where(x => x.Value.Count>0))
            {
                Console.WriteLine($"Side: {djedi.Key}, Members: {djedi.Value.Count}");
                foreach (var item in djedi.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}
