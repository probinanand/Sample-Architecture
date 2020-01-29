using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestArchitecture.Core.Infrastructure.Common;
using TestArchitecture.Core.Repository;

namespace TestArchitecture.Core.Service
{
    public class BaseService<T> : IBaseService<T> where T : class, IEntityWithTypedId<long>, new()
    {
        protected IBaseRepository<T> _repository;
        // public BaseService()
        public BaseService(IBaseRepository<T> repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            var itemsList = await _repository.GetList(filter);
            return itemsList;
        }

        public void Create(T item)
        {
            _repository.Add(item);
        }

        public void Update(T item)
        {
            _repository.Update(item);
        }

        public void Delete(T item)
        {
            _repository.Delete(item);
        }
        public virtual bool IsValid(T item)
        {
            // return _validation.IsValid;
            return false;
        }




    }
}