using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryClasses;

namespace LotteryTests
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void TestSortLowestToHighest()
        {

            int[] array = { 21, 9, 38, 7, 9, 36 };
            int[] arraySorted = { 7, 9, 9, 21, 36, 38 };

            array = array.SortLowestToHighest();
            int count = 0;
            foreach(int element in array)
            {
                Assert.AreEqual(arraySorted[count], element);
                count++;
            }
        }
        [TestMethod]
        public void TestSortHighestToLowest()
        {

            int[] array = { 21, 9, 38, 7, 9, 36 };
            int[] arraySorted = { 38, 36, 21, 9, 9, 7 };

            array = array.SortHighestToLowest();
            int count = 0;
            foreach (int element in array)
            {
                Assert.AreEqual(arraySorted[count], element);
                count++;
            }
        }

        [TestMethod]
        public void TestHasDuplicate()
        {
            int[] array = { 21, 9, 38, 7, 9, 36 };

            Assert.IsTrue(array.HasDuplicate2());
            Assert.IsTrue(array.HasDuplicate());
        }
    }
}
