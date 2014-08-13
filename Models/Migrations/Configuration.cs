namespace Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.UsersContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
			context.Persons.AddOrUpdate(
			  p => p.FirstName,
			  new Person { FirstName = "Andrew Peters", Age=20 },
			  new Person { FirstName = "Brice Lambson", Age=30 },
			  new Person { FirstName = "Rowan Miller",Age=35 }
			);
            //
        }
    }
}
