using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryClasses;

namespace LotteryTests
{
    [TestClass]
    public class LottoTests
    {
        [TestMethod]
        public void TestBonusBall()
        {
            Lotto lotto = new Lotto();

            lotto.BonusBall = 30;

            Assert.AreEqual(lotto.BonusBall, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBonusBallOutOfBounds()
        {
            Lotto lotto = new Lotto();

            lotto.BonusBall = 60;
        }
        [TestMethod]
        public void TestRetailerCode()
        {
            Lotto lotto = new Lotto();

            lotto.retailerCode = "ABCDEFG";

            Assert.AreEqual(lotto.retailerCode, "ABCDEFG");
        }
        [TestMethod]
        public void TestToString()
        {
            string lottoString = "";
            int[] lottoNumbers = { 34, 2, 20, 17, 5, 28 };

            Customer customer = new Customer("name", "12345678901", "customer@email.com");

            Lotto lotto = new Lotto();
            lotto.customer = customer;
            lotto.day = "Saturday";
            lotto.Numbers = lottoNumbers;
            lotto.BonusBall = 40;

            lottoString = lotto.ToString();

            Assert.AreEqual(lottoString, "namecustomer@email.comSaturday240");
        }
    }
}
