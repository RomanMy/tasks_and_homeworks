using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_task
{
    abstract class Shape : IComparable<Shape>, IComparer<Shape>
    {
        public string name;
        public abstract string Name { get; set; }
        public Shape(string n)
        {
            name = n;
        }
        public abstract double Perimeter();
        public abstract double Area();
        public int CompareTo(Shape x)
        {
            if (x != null)
                return this.Area().CompareTo(x.Area());
            else
                throw new Exception("Uncomparable.");
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public int Compare(Shape x1, Shape x2)
        {
            if (x1.Area() > x2.Area())
                return 1;
            else if (x1.Area() < x2.Area())
                return -1;
            else
                return 0;
        }
    }
    class Circle : Shape//, IComparable<Circle>, IComparer<Circle>
    {
        double radius;
        public override string Name { get; set; }
        public Circle(string n, double r) : base(n)
        {
            radius = r;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public int CompareTo(Circle c)
        {
            if (c != null)
                return this.Area().CompareTo(c.Area());
            else
                throw new Exception("Uncomparable.");
        }
        public int CompareTo(Square s)
        {
            if (s != null)
                return this.Area().CompareTo(s.Area());
            else
                throw new Exception("Uncomparable.");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Area() > c2.Area())
                return 1;
            else if (c1.Area() < c2.Area())
                return -1;
            else
                return 0;
        }
        public int Compare(Circle c1, Square s1)
        {
            if (c1.Area() > s1.Area())
                return 1;
            else if (c1.Area() < s1.Area())
                return -1;
            else
                return 0;
        }
    }
    class Square : Shape//, IComparable<Square>, IComparer<Square>
    {
        double side;
        public override string Name { get; set; }
        public Square(string n, double s) : base(n)
        {
            side = s;
        }
        public override double Perimeter()
        {
            return side * 4;
        }
        public override double Area()
        {
            return side * side;
        }
        public int CompareTo(Circle c)
        {
            if (c != null)
                return this.Area().CompareTo(c.Area());
            else
                throw new Exception("Uncomparable.");
        }
        public int CompareTo(Square s)
        {
            if (s != null)
                return this.Area().CompareTo(s.Area());
            else
                throw new Exception("Uncomparable.");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public int Compare(Square s1, Square s2)
        {
            if (s1.Area() > s2.Area())
                return 1;
            else if (s1.Area() < s2.Area())
                return -1;
            else
                return 0;
        }
        public int Compare(Square s1, Circle c1)
        {
            if (s1.Area() > c1.Area())
                return 1;
            else if (s1.Area() < c1.Area())
                return -1;
            else
                return 0;
        }

    }
    class Program
    {
        public static List<Shape> shapes = new List<Shape>();
        static void ProceedInput()
        {
            string input = Console.ReadLine();
            string[] input_array = input.Split(' ');
            if (input_array[0] == "Circle")
                shapes.Add(new Circle(input_array[1], Convert.ToDouble(input_array[2])));
            else if (input_array[0] == "Square")
                shapes.Add(new Square(input_array[1], Convert.ToDouble(input_array[2])));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 shapes and their data: their type ('Circle' or 'Square'), their name, " +
                "their property (radius or side). Separate data elements with single space. Each shape on the new line.");
            ProceedInput();
            ProceedInput();
            ProceedInput();
            ProceedInput();
            //ProceedInput();
            //ProceedInput();
            //ProceedInput();
            //ProceedInput();
            //ProceedInput();
            //ProceedInput();
            Console.WriteLine("Entered shapes:");
            foreach (var i in shapes)
            {
                Console.WriteLine($"The shape {i.name} has perimeter of {i.Perimeter()} and area of {i.Area()}");
            }
            string max_perim = null;
            foreach (var i in shapes)
            {
                double num = 0;
                if (i.Perimeter() > num)
                {
                    num = i.Perimeter();
                    max_perim = i.name;
                }
            }
            Console.WriteLine($"The shape with the largest perimeter is {max_perim}");
            shapes.Sort();
            foreach(var i in shapes)
            {
                Console.WriteLine(i.Area());
            }
            Console.ReadKey();

        }
    }
}
