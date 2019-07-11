using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTests.Tests
{
    [TestClass]
    public class TestingClassToTest
    {
        [TestMethod]
        public void Square5_25expected()
        {
            //arrange
            int arg = 5;
            int expected = 25;
            //act
            ClassToTest c = new ClassToTest();
            int actual = c.Square(arg);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evens1_2_3_4_expected_2_4()
        {
            //arrange
            int[] arg = { 1,2,3,4 };
            int[] expected = { 2,4 };
            //act
            ClassToTest c = new ClassToTest();
            int[] actual = c.Evens(arg);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Greeting()
        {
            //arrange
            string expected = "Hi";
            //act
            ClassToTest c = new ClassToTest();
            string actual = c.Greeting();
            //assert
            StringAssert.AreEqual(expected, actual);
        }
    }
}
