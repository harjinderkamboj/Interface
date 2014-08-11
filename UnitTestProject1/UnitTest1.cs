using Castle.Windsor;
using Castle.Windsor.Installer;
using ClassLibrary1;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using System;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		private static Mock<IPersonRepository> mockPersonRepository;

		public int MyProperty { get; set; }


		[ClassInitialize()]
		public static void ClassSetup(TestContext context)
		{
			mockPersonRepository = new Moq.Mock<IPersonRepository>();
		}

		[TestMethod]
		public void TestMethod1()
		{
			var kernel = BindWithNinject();

			//IRService i = kernel.Get<IRService>();
			var mock = new Moq.Mock<IRService>();
			mock.Setup(f => f.GetDataFromPR(2)).Returns("You said 2");
			//mockPersonRepository.Setup(f => f.getById(2)).Returns("You said 2");
			IRService i = kernel.Get<IRService>();
			//i = new RService();
			Assert.AreEqual("You said 2", i.GetDataFromPR(2));
			//mock.Verify(f => f.AddOne(2), Times.AtLeast(2));
		}

		private static StandardKernel BindWithNinject()
		{
			var kernel = new StandardKernel();
			kernel.Bind<IPersonRepository>().To<PersonRepository>();
			kernel.Bind<IRService>().To<RService>();
			return kernel;
		}


		[TestMethod]
		public void TestMethod2()
		{
			IRService i;
			//i = new RService();
			//Assert.AreEqual(2, i.AddOne(1));
		}


		public void windsor()
		{
			//application starts...
			var container = new WindsorContainer();

			// adds and configures all components using WindsorInstallers from executing assembly
			container.Install(FromAssembly.This());

			// instantiate and configure root component and all its dependencies and their dependencies and...
			var personRepository = container.Resolve<IPersonRepository>();
			//personRepository.getById();

			// clean up, application exits
			container.Dispose();
		}
	
	}


}
