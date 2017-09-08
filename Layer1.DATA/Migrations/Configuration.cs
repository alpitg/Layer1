namespace Layer1.DATA.Migrations
{
    using ENTITIES;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Layer1.DATA.CStudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Layer1.DATA.CStudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.CStudents.AddOrUpdate(
            //  p => p.Id,
            //  new CStudent { Id=1, Name="Alpit", Email="alpit@gmail.com", Age=23, IsDeleted=false }
            //);

        }
    }
}
