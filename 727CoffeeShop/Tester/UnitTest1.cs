using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]        
        public void Login()
        {
            AccountBUS acc = new AccountBUS();
            AccountDTO b = new AccountDTO("admin", "123");
            bool actual = acc.Login(b);
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }
    }
}
