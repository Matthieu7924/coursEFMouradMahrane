namespace EntityFR.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFR.DAO.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFR.DAO.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
