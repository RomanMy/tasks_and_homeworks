using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_OOP_4
{
    class Program
    {
        class Car
        {
            public string Name;
            public string Colour { get; set; }
            public double Price;
            public const string CompanyName = "Merarri";
            public Car()
            {
            }
            public Car(string name, string colour, double price)
            {
                Name = name;
                Colour = colour;
                Price = price;
            }
            string car_info = null;
            public void Input()
            {
                string the_input = Console.ReadLine();
                car_info = the_input;
            }
            public void Print()
            {
                Console.WriteLine(car_info);
            }
            public void ChangePrice(double x)
            {
                Price = Price * (x / 100);
            }
            public static bool operator == (Car c_1, Car car_2)
            {
                if (c_1.Name == car_2.Name & c_1.Price == car_2.Price)
                    return true;
                return false;
            }
            public static bool operator != (Car c_1, Car car_2)
            {
                if (c_1.Name != car_2.Name | c_1.Price != car_2.Price)
                    return true;
                return false;
            }
            public override string ToString()
            {
                string the_output = $"The car {this.Name}, of colour {this.Colour}, costs {this.Price}.";
                return (the_output);
            }
        }
        static void Main(string[] args)
        {
            Car car_1 = new Car("The_car_1_name", "red", 55000);
            Car car_2 = new Car("The_car_2_name", "white", 40000);
            Car car_3 = new Car("The_car_3_name", "blue", 39800);
            car_2.Colour = "violet";
            car_1.ChangePrice(90);
            car_2.ChangePrice(90);
            car_3.ChangePrice(90);
            Console.WriteLine(car_1.ToString());
            Console.WriteLine(car_2.ToString());
            Console.WriteLine(car_3.ToString());
            Console.WriteLine(car_1.Price);
            Console.WriteLine(car_2.Price);
            Console.WriteLine(car_3.Price);
            car_1.Input();
            car_2.Input();
            car_3.Input();
            car_1.Print();
            car_2.Print();
            car_3.Print();
            Console.ReadKey();
        }
    }
}
