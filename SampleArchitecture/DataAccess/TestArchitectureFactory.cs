using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestArchitecture.DataAccess
{
    public class TestArchitectureFactory : IDesignTimeDbContextFactory<TestArchitectureContext>
    {
        public TestArchitectureContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestArchitectureContext>();
            optionsBuilder.UseSqlServer(GlobalConstants.ConnectionString);
            //optionsBuilder.
            return new TestArchitectureContext(optionsBuilder.Options);
        }

    }
}