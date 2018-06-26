using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of dates")
                {
                    break;
                }

                string[] currentStudent = line.Split();


                Student student = new Student();
                string name = currentStudent[0];
                student.Name = name;
                student.Dates = new List<DateTime>();
                student.Comments = new List<string>();

                if (currentStudent.Length > 1)
                {
                    string[] eachDate = currentStudent[1].Split(',');

                    for (int i = 0; i < eachDate.Length; i++)
                    {

                        student.Dates.Add(DateTime.ParseExact(eachDate[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                    if (students.Any(x => x.Name == student.Name))
                    {
                        Student existingStudent = students
                                .First(x => x.Name == student.Name);
                        existingStudent.Dates.AddRange(student.Dates);

                    }
                    else
                    {
                        students.Add(student);
                    }
                }
                else
                {
                    students.Add(student);
                }

            }
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of comments")
                {
                    break;
                }

                string[] currentStudent = line.Split('-');

                Student student = new Student();
                string name = currentStudent[0];
                student.Comments = new List<string>();
                student.Name = name;


                string comment = currentStudent[1];
                student.Comments.Add(comment);

                if (students.Any(x => x.Name == student.Name))
                {
                    Student existingStudent = students
                            .First(x => x.Name == student.Name);

                    existingStudent.Comments.AddRange(student.Comments);
                }                 


            }



            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

    }
}
