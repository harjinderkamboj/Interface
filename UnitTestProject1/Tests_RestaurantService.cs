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
	public class Tests_RestaurantService
	{

		[TestMethod]
		public void TestMethod1()
		{

			var mockPersonRepository = MockRepository.GenerateMock<IRestaurantRepository>();
			mockPersonRepository.Stub(x => x.GetById(2)).Return(new Restaurant{Name="Hifirst"});

			var i = new RestaurantService(mockPersonRepository);

			Assert.AreEqual("Hifirst", i.GetDataFromPR(2).Name);
		}

	
	}


}
