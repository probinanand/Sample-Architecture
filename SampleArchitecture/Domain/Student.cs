using TestArchitecture.Core.Infrastructure.Common;

namespace TestArchitecture.Domain
{
    public class Student:EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}