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
	public class Tests_ClassLibrary
	{

		[TestMethod]
		public void TestMethod1()
		{

			var mockPersonRepository = MockRepository.GenerateMock<IPersonRepository>();
			mockPersonRepository.Stub(x => x.GetById(2)).Return(new Person{FirstName="Hifirst"});

			var i = new RService(mockPersonRepository);

			Assert.AreEqual("Hifirst", i.GetDataFromPR(2).FirstName);
		}

	
	}


}
