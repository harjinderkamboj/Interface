using Castle.Windsor;
using Castle.Windsor.Installer;
using ClassLibrary1;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Rhino.Mocks;
using System;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{

		public int MyProperty { get; set; }



		[TestMethod]
		public void TestMethod1()
		{

			var mock = MockRepository.GenerateMock<IPersonRepository>();
			mock.Stub(x => x.getById(2)).Return("You said 3");

			var i = new RService(mock);

			Assert.AreEqual("You said 2", i.GetDataFromPR(2));
		}

		private static StandardKernel BindWithNinject()
		{
			var kernel = new StandardKernel();
			kernel.Bind<IPersonRepository>().To<PersonRepository>();
			kernel.Bind<IRService>().To<RService>();
			return kernel;
		}
	
	}


}
