using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
	public class PersonRepository : IPersonRepository
	{
		public string getById(int id)
		{
			return string.Format("You requested {0}", id);
		}
	}
}
