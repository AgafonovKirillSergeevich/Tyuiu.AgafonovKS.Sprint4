using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint4.Task5.V6.Lib;

namespace Tyuiu.AgafonovKS.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();


            int[,] mtrx = new int[5, 5]
            {
                { -3, 3, 5, 5, -1 },

                { 5, -1, 4, 3, 0 },

                { 5, 3, -2, -3, 5 },

                { 2, 5, 4, -5, 3 },

                { 3, 3, 0, 2, -5 }
            };
            int[,] res = new int[5, 5]
            {
                { -3, 1, 1, 1, -1 },

                { 1, -1, 1, 1, 0 },

                { 1, 1, -2, -3, 1 },

                { 1, 1, 1, -5, 1 },

                { 1, 1, 0, 1, -5 }
            };


            CollectionAssert.AreEqual(ds.Calculate(mtrx), res);
        }
    }
}
