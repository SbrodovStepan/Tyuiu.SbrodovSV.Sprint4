using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using Tyuiu.SbrodovSV.Sprint4.Task6.V13.Lib;

namespace Tyuiu.SbrodovSV.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] cars = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = dataService.Calculate(cars), wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
