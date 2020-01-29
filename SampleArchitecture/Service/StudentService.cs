using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestArchitecture.Core.Repository;
using TestArchitecture.Core.Repository.EntityFramework;
using TestArchitecture.Core.Service;
using TestArchitecture.DataAccess;
using TestArchitecture.Domain;
using TestArchitecture.Repository;

namespace TestArchitecture.Service
{
    public class StudentService:BaseService<Student>,IStudentService
    {
        //public StudentService() : base(new StudentRepository())
        //{

        //}
        private TestArchitectureContext _dbContext;
        public StudentService(TestArchitectureContext dbContext):base( new BaseRepository<Student>(dbContext))
        {

        }
        
        public StudentService(IStudentRepository repository) : base(repository)
        {
           
        }
    }
}
