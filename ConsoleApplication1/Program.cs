using RestaurantApplication.Services;
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
		private static IKernel _kernal;

		public static void LoadNinject()
		{
			_kernal = new StandardKernel();
			_kernal.Load(Assembly.GetAssembly(typeof(NinjectBindings)));
		}

		static void Main(string[] args)
		{
			LoadNinject();

			IRestaurantService i = _kernal.Get<IRestaurantService>();

			Console.WriteLine(i.GetDataFromPR(2).Name);
			Console.ReadLine();
		}

    }
}
