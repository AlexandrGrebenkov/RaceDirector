using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaceDirector.DataServices
{
    public interface IEntityRepository<T>
        where T : class, new()
    {
        IQueryable<T> GetAll();
        T Get(int id);
        Task CommitChangesAsync();
        void InsertOnCommit(T entity);
        void InsertOnCommit(IEnumerable<T> entities);
        void DeleteOnCommit(T entity);
        void DeleteOnCommit(IEnumerable<T> entities);

        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
