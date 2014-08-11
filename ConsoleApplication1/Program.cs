using ClassLibrary1;
using Ninject;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

	

namespace ConsoleApplication1
{
    public class Program 
    {
		private static IKernel _Kernal;

		public static void LoadNinject()
		{
			_Kernal = new StandardKernel();
			_Kernal.Load(Assembly.GetAssembly(typeof(NinjectBindings)));
		}

		static void Main(string[] args)
		{
			LoadNinject();

			IRService i = _Kernal.Get<IRService>();

			Console.WriteLine(i.GetDataFromPR(2));
			Console.ReadLine();
		}

    }
}
