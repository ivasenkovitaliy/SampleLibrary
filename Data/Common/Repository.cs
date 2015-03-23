using System;
using System.Data.Entity;
using System.Linq;
using Entities;

namespace Data.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly SampleLibraryContext _context;
        protected readonly IDbSet<TEntity> DbSet;

        public Repository()
        {
            _context = new SampleLibraryContext();
            DbSet = _context.CreateSet<TEntity>();
        }

        public IQueryable<TEntity> All()
        {
            return DbSet;
        }

        public virtual TEntity Find(params object[] keyValues)
        {
            if (keyValues == null)
            {
                throw new ArgumentNullException("keyValues");
            }

            return DbSet.Find(keyValues);
        }

        public virtual void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity.DateCreated = DateTime.UtcNow;

            DbSet.Add(entity);

            SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            DbSet.Attach(entity);

            _context.SetState(entity, EntityState.Modified);

            SaveChanges();
        }

        public virtual void Delete(params object[] keyValues)
        {
            if (keyValues == null)
            {
                throw new ArgumentNullException("keyValues");
            }

            var entity = Find(keyValues);

            DbSet.Remove(entity);

            SaveChanges();
        }

        public virtual void Detach(TEntity entity)
        {
            _context.SetState(entity, EntityState.Detached);
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
