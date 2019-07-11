using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_many_task
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Courses { get; set; }
    }
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {Name = "Tom", Courses = new List<string> { "HTML", "CSS" } },
            new Student {Name = "Sam", Courses = new List<string> { "HTML", "CSS", "JavaScript" } },
            new Student {Name = "Andrew", Courses = new List<string> { "JavaScript", "SQL" } },
            new Student {Name = "William", Courses = new List<string> { "SQL", "C#" } },
        };
        static void Main(string[] args)
        {
            foreach (Student i in students)
            {
                Console.WriteLine($"{i.Name} - {i.Courses.Count()}");
            }
            Console.WriteLine();
            var selectedStudents = students.SelectMany(stu => stu.Courses,
                (stu, cor) => new { stuart = stu, Course = cor}).Where(stu => stu.Course == "JavaScript"
                && stu.stuart.Name.ToLower().Contains('a'));
            foreach (var i in selectedStudents)
            {
                Console.WriteLine($"{i.stuart.Name} - {i.Course}");
            }



            Console.ReadKey();
        }
    }
}
