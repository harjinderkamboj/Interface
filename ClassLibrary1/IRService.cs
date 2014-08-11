using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public interface IRService
	{
		string GetResponse(string req);

		int AddOne(int p);
		string GetDataFromPR(int id);
	}
}
