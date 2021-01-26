using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerApp.DataAccess
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetByID(int id);
        int Insert(T entity);
        void Update(T entity);
        void DeleteByID(int id);
    }
}
