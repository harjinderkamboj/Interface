using Castle.Windsor;
using Castle.Windsor.Installer;
using ClassLibrary1;
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
        public void Test_Person_Repository()
        {

            IPersonRepository p = new PersonRepository();

            Assert.AreEqual("Firsty", p.GetById(2).FirstName);
        }


    }


}
