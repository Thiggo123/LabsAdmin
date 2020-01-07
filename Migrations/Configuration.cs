namespace Labs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Labs.Data.ContextApp>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Labs.Data.ContextApp";
        }

        protected override void Seed(Labs.Data.ContextApp context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
