using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestArchitecture.Core.Repository.EntityFramework;
using TestArchitecture.Core.Service;
using TestArchitecture.DataAccess;
using TestArchitecture.Domain;
using TestArchitecture.Repository;

namespace TestArchitecture.Service
{
    public class TeacherService:BaseService<Teacher>,ITeacherService
    {
        private TestArchitectureContext _dbContext;
        public TeacherService(TestArchitectureContext dbContext) : base(new BaseRepository<Teacher>(dbContext))
        {

        }

        public TeacherService(ITeacherRepository repository) : base(repository)
        {

        }
    }
}
