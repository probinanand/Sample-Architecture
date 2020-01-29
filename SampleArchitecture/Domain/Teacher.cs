using TestArchitecture.Core.Infrastructure.Common;

namespace TestArchitecture.Domain
{
    public class Teacher:EntityBase
    {
        //public Teacher()
        //{

        //}
        //public Teacher(long iid)
        //{
        //    Id = iid;
        //}
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}