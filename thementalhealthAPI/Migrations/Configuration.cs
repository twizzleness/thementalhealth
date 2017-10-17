using thementalhealthAPI.Models;

namespace thementalhealthAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<thementalhealthAPI.Models.thementalhealthAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(thementalhealthAPI.Models.thementalhealthAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Clients.AddOrUpdate(c => c.Id,
                new Client{Name = "A mental health service", Email = "test@test.com", PhoneNumber = "3067777777"}
                );

            context.Listings.AddOrUpdate(l => l.Id,
                new Listing{Description = "This is a listing", Image = "some file path", ClientId = 1, Link = "some url"}
                );

        }
    }
}
