using System;
using System.Collections.Generic;

namespace Leave_Mgmt.Contracts
{
    public interface IRepositoryBase<T> where T: class
    {
        ICollection<T> FindAll();

        bool isExists(int id);

        T FindById(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}
