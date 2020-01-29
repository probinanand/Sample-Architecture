using TestArchitecture.Core.Repository.EntityFramework;
using TestArchitecture.DataAccess;
using TestArchitecture.Domain;

namespace TestArchitecture.Repository
{
    public class TeacherRepository:BaseRepository<Teacher>
    {
        private TestArchitectureContext _dbContext;

        public TeacherRepository(TestArchitectureContext context) : base(context)
        {
            _dbContext = context;
        }

    }
}