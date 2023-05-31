using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 5;
            int x = a + b;
            Assert.AreEqual(15, x);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int a = 15;
            int b = 5;
            int x = a + b;
            Assert.AreEqual(20, x);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int a = 20;
            int b = 5;
            int x = a - b;
            Assert.AreEqual(15, x);
        }
    }
}
