using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryClasses;

namespace LotteryTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestEmail()
        {
            Customer customer = new Customer();

            customer.Email = "customer@email.com";

            Assert.AreEqual(customer.Email, "customer@email.com");
        }
        [TestMethod]
        public void TestName()
        {
            Customer customer = new Customer();

            customer.Name = "name";

            Assert.AreEqual(customer.Name, "name");
        }
        [TestMethod]
        public void TestPhone()
        {
            Customer customer = new Customer();

            customer.Phone = "12345678901";

            Assert.AreEqual(customer.Phone, "12345678901");
        }
        [TestMethod]
        public void TestConstructor()
        {
            Customer customer = new Customer("name", "12345678901", "customer@email.com");

            Assert.AreEqual(customer.Name, "name");
            Assert.AreEqual(customer.Phone, "12345678901");
            Assert.AreEqual(customer.Email, "customer@email.com");
        }
    }
}
