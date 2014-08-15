
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplication.Services
{
	public interface IRestaurantService
	{
		string GetResponse(string req);

		int AddOne(int p);
		Restaurant GetDataFromPR(int id);
	}
}
