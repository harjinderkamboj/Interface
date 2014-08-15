using Castle.Windsor;
using Castle.Windsor.Installer;
using RestaurantApplication.Services;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Integration_tests
    {

        [TestMethod]
        public void Test_Restaurant_Repository()
        {

            IRestaurantRepository p = new RestaurantRepository();

            Assert.AreEqual("Firsty", p.GetById(2).Name);
        }


    }


}
