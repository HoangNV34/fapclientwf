using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FapClient.Core.Repository
{
    public interface ICoreRepository<T>
    {
        T GetById(int id);

        int Add(T entity);

        bool Delete(T entity);

        bool Update(T entity);

        bool Delete(int id);

        int AddRange(List<T> entities);

        IQueryable<T> GetQuery();

        IQueryable<T> GetQuery(Expression<Func<T, bool>> where);
    }
}
