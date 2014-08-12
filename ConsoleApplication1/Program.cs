using ClassLibrary1;
using Ninject;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models;

	

namespace ConsoleApplication1
{
    public class Program 
    {
		private static IKernel _kernal;

		public static void LoadNinject()
		{
			_kernal = new StandardKernel();
			_kernal.Load(Assembly.GetAssembly(typeof(NinjectBindings)));
		}

		static void Main(string[] args)
		{
			LoadNinject();

			IRService i = _kernal.Get<IRService>();

			Console.WriteLine(i.GetDataFromPR(2).FirstName);
			Console.ReadLine();
		}

    }
}
