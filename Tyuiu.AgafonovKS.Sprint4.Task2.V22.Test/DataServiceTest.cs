using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint4.Task2.V22.Lib;

namespace Tyuiu.AgafonovKS.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 6, 3, 4, 1, 6, 4, 3, 6, 5, 2, 3, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 2025;

            Assert.AreEqual(wait, res);
        }
    }
}
