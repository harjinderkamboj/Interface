using ClassLibrary1;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
	public class NinjectBindings : Ninject.Modules.NinjectModule
	{
		public override void Load()
		{
			Bind<IPersonRepository>().To<PersonRepository>();
			Bind<IRService>().To<RService>();

		}
	}
}
