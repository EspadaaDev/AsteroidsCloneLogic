using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameLogic;

namespace LogicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsInstanceOfType(new Core(), typeof(Core));
        }
    }
}
