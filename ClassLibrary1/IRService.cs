using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public interface IRService
	{
		string getResponse(string req);

		int AddOne(int p);
	}
}
