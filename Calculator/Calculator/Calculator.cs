using System;


namespace Calculator
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static int Square(int x)
        {
            return x * x;
        }
        public static double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
