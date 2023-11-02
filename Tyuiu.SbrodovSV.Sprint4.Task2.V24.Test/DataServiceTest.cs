using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint4.Task2.V24.Lib;

namespace Tyuiu.SbrodovSV.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] nums = { 4, 3, 3, 9, 5, 6, 5, 6, 4, 5, 7, 3 };
            int res = dataService.Calculate(nums), wait = 40;
            Assert.AreEqual(wait, res);
        }
    }
}
