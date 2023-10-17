using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint1.TaskReview.V3.Lib;
namespace Tyuiu.ShunanovKE.Sprint1.TaskReview.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1, y = 2;
            double res = ds.Calculate(x, y);
            double wait = 3.964;

            Assert.AreEqual(wait, res);
        }
    }
}
