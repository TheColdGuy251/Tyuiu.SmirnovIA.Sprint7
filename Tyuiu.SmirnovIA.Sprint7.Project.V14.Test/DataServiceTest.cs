using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovIA.Sprint7.Project.V14.Lib;

namespace Tyuiu.SmirnovIA.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string[,] array = { { "1", "Автобус", "51", "25.10.2005", "Карнацевича", "bvcb", "21", ""},
                            { "2", "Автобус", "3", "25.10.2005", "Карнацевича", "bcvc", "15", ""},
                            { "3", "Маршрутное такси", "24", "25.10.2005", "Карнацевича", " ", "3", ""},
                            { "4", "Автобус", "51", "25.10.2005", "Карнацевича", "bcvb", "45", ""},
                            { "5", "Автобус", "51", "25.10.2005", "Карнацевича", "df", "22", ""}};
        int id = 51;
        [TestMethod]
        public void TestLibVA()
        {
            int res = ds.VehicleAmount(array);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestLibRA()
        {
            int res = ds.RouteAmount(array);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestLibMin()
        {
            int res = ds.MinTime(array);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestLibMax()
        {
            int res = ds.MaxTime(array);
            Assert.AreEqual(45, res);
        }
        [TestMethod]
        public void TestLibAvg()
        {
            int res = ds.AvgTime(array);
            Assert.AreEqual(21, res);
        }
        [TestMethod]
        public void TestLibRA_R()
        {
            int res = ds.RouteAmount_Route(array, id);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestLibMin_R()
        {
            int res = ds.MinTime_Route(array, id);
            Assert.AreEqual(21, res);
        }
        [TestMethod]
        public void TestLibMax_R()
        {
            int res = ds.MaxTime_Route(array, id);
            Assert.AreEqual(45, res);
        }
        [TestMethod]
        public void TestLibAvg_R()
        {
            int res = ds.AvgTime_Route(array, id);
            Assert.AreEqual(29, res);
        }
    }
}
