﻿using Castle.Windsor;
using Castle.Windsor.Installer;
using ClassLibrary1;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethod1()
		{

			var mockPersonRepository = MockRepository.GenerateMock<IPersonRepository>();
			mockPersonRepository.Stub(x => x.getById(2)).Return("You said 2");

			var i = new RService(mockPersonRepository);

			Assert.AreEqual("You said 2", i.GetDataFromPR(2));
		}

	
	}


}
