using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace serialization_task
{
    [Serializable]
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        protected double Rating { get; set; }
        [DataMember]
        public string Group { get; set; }
        public Student()
        { }
    }
    public class Group
    {
        public string Name { get; set; }
    }
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {Name = "Tom", Group = "Group_1" },
            new Student {Name = "Sam", Group = "Group_1" },
            new Student {Name = "Andrew", Group = "Group_1" },
            new Student {Name = "William", Group = "Group_1" },
            new Student {Name = "Calvin", Group = "Group_2" },
            new Student {Name = "Jack", Group = "Group_2" },
            new Student {Name = "Anthony", Group = "Group_2" },
            new Student {Name = "Michael", Group = "Group_2" },
            new Student {Name = "John", Group = "Group_3" },
            new Student {Name = "Peter", Group = "Group_3" },
            new Student {Name = "Dave", Group = "Group_3" },
            new Student {Name = "James", Group = "Group_3" }
        };
        static Student[] alternativeList =
        {
            new Student {Name = "Tom", Group = "Group_1" },
            new Student {Name = "Sam", Group = "Group_1" },
            new Student {Name = "Andrew", Group = "Group_1" },
            new Student {Name = "William", Group = "Group_1" },
            new Student {Name = "Calvin", Group = "Group_2" },
            new Student {Name = "Jack", Group = "Group_2" },
            new Student {Name = "Anthony", Group = "Group_2" },
            new Student {Name = "Michael", Group = "Group_2" },
            new Student {Name = "John", Group = "Group_3" },
            new Student {Name = "Peter", Group = "Group_3" },
            new Student {Name = "Dave", Group = "Group_3" },
            new Student {Name = "James", Group = "Group_3" }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter serialization format:");
            string input = Console.ReadLine().ToLower();
            if(input == "binary")
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, students);
                    Console.WriteLine("Binary: Serialized");
                }
                using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
                {
                    List<Student> newStudents = (List<Student>)formatter.Deserialize(fs);
                    Console.WriteLine("Binary: Deserialized");
                    foreach(Student stu in newStudents)
                    {
                        Console.WriteLine(stu.Name);
                        Console.WriteLine(stu.Group);
                        Console.WriteLine();
                    }
                }
            }
            else if(input == "soap")
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream fs = new FileStream("students.soap", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, alternativeList);
                    Console.WriteLine("Soap: Serialized");
                }
                using (FileStream fs = new FileStream("students.soap", FileMode.OpenOrCreate))
                {
                    Student[] newStudents = (Student[])formatter.Deserialize(fs);
                    Console.WriteLine("Soap: Deserialized");
                    foreach (Student stu in newStudents)
                    {
                        Console.WriteLine(stu.Name);
                        Console.WriteLine(stu.Group);
                        Console.WriteLine();
                    }
                }
            }
            else if(input == "xml")
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, students);
                    Console.WriteLine("Xml: Serialized");
                }
                using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
                {
                    List<Student> newStudents = (List<Student>)formatter.Deserialize(fs);
                    Console.WriteLine("Xml: Deserialized");
                    foreach (Student stu in newStudents)
                    {
                        Console.WriteLine(stu.Name);
                        Console.WriteLine(stu.Group);
                        Console.WriteLine();
                    }
                }
            }
            else if(input == "json")
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream("students.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, students);
                    Console.WriteLine("Json: Serialized");
                }
                using (FileStream fs = new FileStream("students.json", FileMode.OpenOrCreate))
                {
                    List<Student> newStudents = (List<Student>)jsonFormatter.ReadObject(fs);
                    Console.WriteLine("Json: Deserialized");
                    foreach (Student stu in newStudents)
                    {
                        Console.WriteLine(stu.Name);
                        Console.WriteLine(stu.Group);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Serialization format should be one of the following: binary, soap, xml, json.");
            }
            Console.ReadKey();
        }
    }
}
