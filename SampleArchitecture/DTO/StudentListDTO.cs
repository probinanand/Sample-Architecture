using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestArchitecture.DTO
{
    public class StudentListDTO
    {
        public long StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class TeacherList
    {
        public long TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}
