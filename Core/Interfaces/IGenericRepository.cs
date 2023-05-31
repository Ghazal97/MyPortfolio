using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IGenericRepository<T> where T : class
    {

        IEnumerable<T> GetAllEntities();

        T GetById(object id);

        void CreateEntity(T t);

        void UpdateEntity(T t);

        void DeleteEntity(object id);
    }
}