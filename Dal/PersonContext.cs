using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
	public class PersonContext : DbContext
	{
		public PersonContext() : base("name=Person_Entities") { }
		public DbSet<Person> Persons { get; set; }
	}
}
