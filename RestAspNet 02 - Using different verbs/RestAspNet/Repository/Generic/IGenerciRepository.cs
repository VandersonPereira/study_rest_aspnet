using RestAspNet.Models.Base;
using System.Collections.Generic;

namespace RestAspNet.Repository.Generic
{
    public interface IGenerciRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T FindById(long id);
        List<T> FindAll();
        T Update(T entity);
        void Delete(long id);
        bool Exist(long? id);
    }
}
