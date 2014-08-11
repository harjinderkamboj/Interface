using ClassLibrary1;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	

namespace ConsoleApplication1
{
    class Program 
    {
		//private static IRService inf;


		//public Program(IRService inf)
		//{
		//	inf = new RService();
		//}

		static void Main(string[] args)
		{
			//var kernel = BindWithNinject();

			//IRService i = kernel.Get<IRService>();

			//Console.WriteLine(i.AddOne(1));
			Console.ReadLine();

		}

		//private static StandardKernel BindWithNinject()
		//{
		//	//var kernel = new StandardKernel();
		//	//kernel.Bind<IPersonRepository>().To<PersonRepository>();
		//	//kernel.Bind<IRService>().To<RService>();
		//	//return kernel;
		//}
    }
}
