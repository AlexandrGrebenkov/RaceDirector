using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaceDirector.Data;

namespace RaceDirector.DataServices
{
    public class EntityRepository<T> : IEntityRepository<T>
        where T : class, new()
    {
        private readonly ApplicationDbContext context;

        public EntityRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CommitChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void DeleteOnCommit(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteOnCommit(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void InsertOnCommit(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void InsertOnCommit(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
