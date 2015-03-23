using System.Data.Entity;
using Entities;

namespace Data.Common
{
    class SampleLibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<User> Users { get; set; }

        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public void SetState<TEntity>(TEntity entity, EntityState state) where TEntity : class
        {
            Entry(entity).State = state;
        }
    }
}
