using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserTest2 log = new UserTest2();
            Assert.AreEqual(false, log.Login("admin", "I forgot my password * ^&!$"), "admin/<anyting else> should be a bad login");

        }
    }
}
