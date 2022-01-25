using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryClasses;

namespace LotteryTests
{
    [TestClass]
    public class EuroTests
    {
        [TestMethod]
        public void TestLuckyStar()
        {
            int[] luckyStarNumbers = { 12, 46 };

            Euro euro = new Euro
            {
                LuckyStar = luckyStarNumbers
            };

            Assert.AreEqual(euro.LuckyStar, luckyStarNumbers);
        }
        [TestMethod]
        public void TestCountry()
        {
            Euro euro = new Euro();

            euro.Country = "Germany";

            Assert.AreEqual(euro.Country, "Germany");
        }
        [TestMethod]
        public void TestToString()
        {
            string euroString;
            int[] euroNumbers = { 1, 33, 3, 4, 5, 6 };

            Euro euro = new Euro();
            Customer customer = new Customer("name", "12345678901", "customer@email.com");

            euro.customer = customer;
            euro.day = "Sunday";
            euro.Numbers = euroNumbers;
            euro.Country = "France";

            euroString = euro.ToString();

            Assert.AreEqual(euroString, "namecustomer@email.comSunday33France");
        }
    }
}
