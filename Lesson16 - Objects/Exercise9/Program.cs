using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split('-');

                string creator = line[0];
                string teamName = line[1];
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    Team team = new Team
                    {
                        Creator = creator,
                        TeamName = teamName,
                        Members = new List<string>()
                    };
                    teams.Add(team);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of assignment")
                {
                    break;
                }

                string[] membersInput = line.Split(new char[] {'-','>'},StringSplitOptions.RemoveEmptyEntries);
                string member = membersInput[0];
                string teamName = membersInput[1];

                if (!teams.Any(x =>x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x=>x.Members.Contains(member)) || teams.Any(x=>x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var player in teams.Where(x =>x.TeamName == teamName))
                    {
                        player.Members.Add(member);
                    }

                }

            }

            foreach (var team in teams.Where(x =>x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x=>x.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x => x.Members.Count == 0).OrderBy(x=>x.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
    }
}
