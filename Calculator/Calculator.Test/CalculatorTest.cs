using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [DataRow(100, 10)]
        public void SquareRoot100_expected10(int x, double expected)
        {
            double actual = Calculator.SquareRoot(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(10, 20, 30)]
        public void Add10_20_expected30(int x, int y, int expected)
        {
            int actual = Calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow (10, 20, -10)]
        public void Substract10_20_expectednegative10(int x, int y, int expected)
        {
            int actual = Calculator.Subtract(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(10, 20, 200)]
        public void Multiply10_20_expected_200(int x, int y, int expected)
        {
            int actual = Calculator.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(10, 20, 0.5)]
        public void Divide10_20_expectedhalf(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(10, 100)]
        public void Square10_expected_100(int x, int expected)
        {
            int actual = Calculator.Square(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
