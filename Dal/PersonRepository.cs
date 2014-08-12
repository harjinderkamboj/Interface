using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
	public class PersonRepository : IPersonRepository
	{
		public Person getById(int id)
		{
			//return new Person { PersonId = id, FirstName = "Firsty", LastName = "Lasty", Age = 30 };
			using (var db = new PersonContext())
			{
				var query = from p in db.Persons
							where p.PersonId == id
							select p;

				return query.FirstOrDefault();
			}
			
			
			
		}


	}
}
