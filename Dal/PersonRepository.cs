
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
	public class RestaurantRepository : IRestaurantRepository
	{
		public Restaurant GetById(int id)
		{
			return new Restaurant { Id = id, Name = "Firsty", City = "Lasty", Capacity = 30 };
			//using (var db = new UsersContext())
			//{
			//	var query = from p in db.Persons
			//				where p.PersonId == id
			//				select p;

			//	return query.FirstOrDefault();
			//}
			
			
			
		}


	}
}
