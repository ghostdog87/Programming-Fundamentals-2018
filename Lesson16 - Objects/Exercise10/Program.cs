using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                if (line.Contains("=>"))
                {
                    Town town = new Town();

                    string[] inputLine = line.Split(new char[] {'=','>'},StringSplitOptions.RemoveEmptyEntries);
                    string townName = inputLine[0];


                    int seats = int.Parse(inputLine[1].Trim().Split()[0]);
                    town.Name = townName;
                    town.SeatsCount = seats;
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Student students = new Student();
                    string[] inputLine = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string studentName = inputLine[0].Trim();
                    string email = inputLine[1].Trim();
                    DateTime date = DateTime.ParseExact(inputLine[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    students.Name = studentName;
                    students.Email = email;
                    students.RegistrationDate = date;

                    towns.LastOrDefault().Students.Add(students);


                }
                
            }

            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x=>x.Name))
            {
                var students = town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount)
                        .OrderBy(x => x.RegistrationDate)
                        .ThenBy(x => x.Name)
                        .ThenBy(x => x.Email);
                    groups.Add(group);

                }
            }


            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups.OrderBy(x=>x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name}=> {string.Join(", ", group.Students.Select(x => x.Email).ToList())}");              
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
