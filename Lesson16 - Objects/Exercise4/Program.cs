using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades  => Grades.Average();

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] line = Console.ReadLine().Split();
                student.Name = line[0];
                student.Grades = line.Skip(1).Select(double.Parse).ToList();

                students.Add(student);

            }

            var result = students.Where(x => x.AverageGrades >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrades:f2}");
            }

        }
    }
}
