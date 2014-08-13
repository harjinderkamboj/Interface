using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class UsersContext : DbContext
	{
		public UsersContext() : base("name=Person_Entities") { }
		public DbSet<Person> Persons { get; set; }
	}
}
