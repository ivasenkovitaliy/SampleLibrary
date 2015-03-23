using System.Linq;
using Entities;

namespace Data.Common
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        IQueryable<TEntity> All();

        TEntity Find(params object[] keyValues);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(params object[] keyValues);

        void SaveChanges();
    }
}