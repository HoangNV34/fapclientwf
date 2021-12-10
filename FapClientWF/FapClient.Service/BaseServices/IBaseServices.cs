using System.Collections.Generic;

namespace FapClient.Service.BaseServices
{
    public interface IBaseServices<TEntity>
    {
        int Add(TEntity entity);

        int AddRange(IEnumerable<TEntity> entities);

        bool Update(TEntity entity);

        bool Delete(int id);

        bool Delete(TEntity entity);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
    }
}
