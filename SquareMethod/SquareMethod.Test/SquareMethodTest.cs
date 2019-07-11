using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareMethod.Test
{
    [TestClass]
    public class SquareMethodTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            int x = 5;
            int expected = 225;
            //act
            int actual = SquareMethod.Square(x);

            //assert
            Assert.AreSame(expected, actual);
        }
    }
}
