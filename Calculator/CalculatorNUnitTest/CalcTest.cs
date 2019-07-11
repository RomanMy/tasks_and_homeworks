using System;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class CalcTest
    {
        /*[OneTimeSetUp]
        public void BeforeAllMethods()
        {
            Console.WriteLine("[OneTimeSetUp] public void BeforeAllMethods()");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            Console.WriteLine("[OneTimeTearDown] public void AfterAllMethods()");
        }*/

        [TestCase(10, 20, ExpectedResult = 30)]
        public int Adding(int x, int y)
        {
            return Calculator.Calculator.Add(x, y);
        }
        [TestCase(10, 20, ExpectedResult = -10)]
        public int Subtracting(int x, int y)
        {
            return Calculator.Calculator.Subtract(x, y);
        }

        [TestCase(10, 20, 200)]
        public void Multiplying(int x, int y, int expected)
        {
            int actual = Calculator.Calculator.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 20, 0.5)]
        public void Dividing(double x, double y, double expected)
        {
            double actual = Calculator.Calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }

        //Data provider
        private static readonly object[] Data1 =
        {
            new object[] {10, 100},
            new object[] {5, 25},
            new object[] {2, 4}
        };
        [Test, TestCaseSource(nameof(Data1))]
        public void Square(int x, int expected)
        {
            int actual = Calculator.Calculator.Square(x);
            Assert.AreEqual(expected, actual);
        }
        //Data provider
        private static readonly object[] Data2 =
        {
            new object[] {100, 10},
            new object[] {25, 5},
            new object[] {4, 2}
        };
        [Test, TestCaseSource(nameof(Data2))]
        public void SquareRoot(int x, double expected)
        {
            double actual = Calculator.Calculator.SquareRoot(x);
            Assert.AreEqual(expected, actual);
        }
    }
}