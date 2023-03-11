using Database.Infra;
using Database.Interfaces;
using Database.Models;
using LiteDB;
using System.Linq.Expressions;

namespace Database.Service
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ILiteCollection<T> _collection;
        public BaseRepository(string collectionName)
        {
            DatabaseInstance databaseInstance = DatabaseInstance.GetInstance();
            databaseInstance.x = 10;
            _collection = databaseInstance.database.GetCollection<T>(collectionName);
        }

        public List<T> Query(Expression<Func<T, bool>> expression) 
        {
            return _collection.Query().Where(expression).ToList(); 
        }

        public T FindById(int id)
        {
            return _collection.FindById(id);
        }

        public void Add(T entity)
        {
            _collection.Insert(entity);
        }

        public void Update(T entitie)
        {
            _collection.Update(entitie);
        }

        public void Delete(int id)
        {
            _collection.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _collection.FindAll();
        }
    }
}
