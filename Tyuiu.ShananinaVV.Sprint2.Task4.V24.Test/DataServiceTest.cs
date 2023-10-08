using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint2.Task4.V24.Lib;

namespace Tyuiu.ShananinaVV.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = -20;
            double res = ds.Calculate(x, y);
            double wait = -164.616;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 3.159;
            Assert.AreEqual(wait, res);
        }
    }
}
