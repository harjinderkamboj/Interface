using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using Moq;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		private static Mock<IRService> mock;

		public static Mock<IRService> Mock
		{
			get { return UnitTest1.mock; }
			set { UnitTest1.mock = value; }
		}

		[ClassInitialize()]
		public static void ClassSetup(TestContext context)
		{
			mock = new Moq.Mock<IRService>();
		}

		[TestMethod]
		public void TestMethod1()
		{
			//Setup();
			mock.Setup(f => f.AddOne(2)).Returns(3);
			IRService i = mock.Object;
			//i = new RService();
			Assert.AreEqual(3, i.AddOne(2));
			//mock.Verify(f => f.AddOne(2), Times.AtLeast(2));
		}


		[TestMethod]
		public void TestMethod2()
		{
			IRService i;
			i = new RService();
			Assert.AreEqual(2, i.AddOne(1));
		}

		
	}
}
