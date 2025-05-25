// Infra/DesignTimeDbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infra.Persistence;

namespace Infra
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TasksDbContext>
    {
        public TasksDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TasksDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TasksDatabase;User ID=sa;Password=Xy23h2o1@Sql;TrustServerCertificate=True;");

            return new TasksDbContext(optionsBuilder.Options);
        }
    }
}