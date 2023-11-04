using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint4.Task0.V13.Lib;

namespace Tyuiu.AgafonovKS.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] Array = new int[] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int wait = 26;
            int res = ds.GetSumEvenArrEl(Array);
            Assert.AreEqual(wait, res);
        }
    }
}
