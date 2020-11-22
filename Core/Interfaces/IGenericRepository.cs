using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //CRUD
        IEnumerable<T> GetAll();
        T GetByOne(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
