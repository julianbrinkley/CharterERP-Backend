namespace CharterERP.Backend.Repository.Migrations
{
    using CharterERP.Backend.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharterERP.Backend.Repository.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CharterERP.Backend.Repository.EFDbContext context)
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

            context.Products.AddOrUpdate(
                p => p.Name, //value that it checks against.
                new Product { Name = "Boat", Category = "Watercraft", Description="A Lioncatcher 9000 Speed Boat", Price = 12500.00M },
                new Product { Name = "Basketball Goal", Category = "Sports Equipment", Description = "A Nielsen XJ Basketball Goal", Price = 900.00M },
                new Product { Name = "Soccer Goal", Category = "Soccer Equipment", Description = "A Fieldenstein Soccer Goal", Price = 1900.00M },
                new Product { Name = "Jet Ski", Category = "Watercraft", Description="A Lioncatcher 1600 Jet Ski", Price = 5200.00M },
                new Product { Name = "Baseball Bat", Category = "Baseball Equipment", Description = "A Wilson Baseball Bat", Price = 179.00M },
                new Product { Name = "Playground Set", Category = "Sports Equipment", Description = "A Good Kids Playground Set ", Price = 29900.00M }
                );
                
        }
    }
}
