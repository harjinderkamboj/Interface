
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
	public class UsersContext : DbContext
	{
		public UsersContext() : base("name=DefaultConnection") { }
		public DbSet<Person> Persons { get; set; }
	}
}
