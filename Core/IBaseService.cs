using Poslasticarnica.Model;

namespace Poslasticarnica.Core
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Get(long Id);
        TEntity Add(TEntity entity);

        bool Update(long id, TEntity entity);

        bool Delete(long Id);
    }
}
