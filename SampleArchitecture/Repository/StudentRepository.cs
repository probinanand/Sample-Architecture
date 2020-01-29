using TestArchitecture.Core.Repository.EntityFramework;
using TestArchitecture.DataAccess;
using TestArchitecture.Domain;

namespace TestArchitecture.Repository
{
    public class StudentRepository:BaseRepository<Student>
    {
        private TestArchitectureContext _dbContext;
        public StudentRepository(TestArchitectureContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}