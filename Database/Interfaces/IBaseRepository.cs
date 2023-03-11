using Database.Models;
using LiteDB;
using System.Linq.Expressions;

namespace Database.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        T FindById(int id);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
