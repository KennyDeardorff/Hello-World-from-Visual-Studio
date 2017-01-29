using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SayHelloRespondsCorrectly()
        {
            const string name = "Kenny";
            const string expected = "Hello, Kenny!";

            var actual = Hello.SayHi(name);

            Assert.AreEqual(expected, actual);
        }
    }
}
