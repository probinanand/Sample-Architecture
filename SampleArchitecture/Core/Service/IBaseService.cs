using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TestArchitecture.Core.Service
{
    public interface IBaseService<T>
    {
        Task<IList<T>> GetAll(Expression<Func<T, bool>> filter = null);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        bool IsValid(T item);
    }
}