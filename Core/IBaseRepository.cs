using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;

namespace Poslasticarnica.Core
{
    public interface IBaseRepository<TEntity> where TEntity:class
    {
        TEntity Get (long Id);
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll(int page, int perPage, string sort, string direction);

        IEnumerable<TEntity> Search(string term = "");

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Detach(TEntity entity);





    }
}
