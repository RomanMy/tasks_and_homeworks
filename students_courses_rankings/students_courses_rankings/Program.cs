using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_courses_rankings
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Courses { get; set; }
        public double Rating { get; set; }
        public string Group { get; set; }
    }
    class Group
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
    class Program
    {
        static List<Group> groups = new List<Group>
        {
            new Group {Name = "Group_1", Specialization = "Development"},
            new Group {Name = "Group_2", Specialization = "Testing"},
            new Group {Name = "Group_3", Specialization = "Automatio"},
        };
        static List<Student> students = new List<Student>
        {
            new Student {Name = "Tom", Courses = new List<string> { "HTML", "CSS" }, Rating = 91.5, Group = "Group_1" },
            new Student {Name = "Sam", Courses = new List<string> { "HTML", "CSS", "JavaScript" }, Rating = 91.0, Group = "Group_1" },
            new Student {Name = "Andrew", Courses = new List<string> { "JavaScript", "SQL" }, Rating = 89.5, Group = "Group_1" },
            new Student {Name = "William", Courses = new List<string> { "SQL", "C#" }, Rating = 90.5, Group = "Group_1" },
            new Student {Name = "Calvin", Courses = new List<string> { "HTML", "CSS" }, Rating = 92.0, Group = "Group_2" },
            new Student {Name = "Jack", Courses = new List<string> { "HTML", "CSS", "JavaScript" }, Rating = 90.0, Group = "Group_2" },
            new Student {Name = "Anthony", Courses = new List<string> { "JavaScript", "SQL" }, Rating = 88.0, Group = "Group_2" },
            new Student {Name = "Michael", Courses = new List<string> { "SQL", "C#" }, Rating = 86.5, Group = "Group_2" },
            new Student {Name = "John", Courses = new List<string> { "HTML", "CSS" }, Rating = 95.5, Group = "Group_3" },
            new Student {Name = "Peter", Courses = new List<string> { "HTML", "CSS", "JavaScript" }, Rating = 93.5, Group = "Group_3" },
            new Student {Name = "Dave", Courses = new List<string> { "JavaScript", "SQL" }, Rating = 86.5, Group = "Group_3" },
            new Student {Name = "James", Courses = new List<string> { "SQL", "C#" }, Rating = 92.5, Group = "Group_3" }
        };
        static void Main(string[] args)
        {
            /*foreach (Student i in students)
            {
                Console.WriteLine($"{i.Name} - {i.Courses.Count()}");
            }
            Console.WriteLine();
            var selectedStudents = students.SelectMany(stu => stu.Courses,
                (stu, cor) => new { stuart = stu, Course = cor }).Where(stu => stu.Course == "JavaScript"
                 && stu.stuart.Name.ToLower().Contains('a'));
            foreach (var i in selectedStudents)
            {
                Console.WriteLine($"{i.stuart.Name} - {i.Course}");
            }*/

            var the_groups = groups.GroupJoin(students,
                gr => gr.Name,
                st => st.Group,
                (group, sts) => new {
                    Name = group.Name,
                    Specialization = group.Specialization,
                    Students = sts.Select(st => st.Name),
                    AvgRatings = (sts.Select(st => st.Rating)).Sum() / sts.Count()
                });
            foreach(var group in the_groups)
            {
                Console.WriteLine(group.Name);
                Console.WriteLine($"The average rating is {group.AvgRatings}");
                foreach(string stud in group.Students)
                {
                    Console.WriteLine(stud);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
