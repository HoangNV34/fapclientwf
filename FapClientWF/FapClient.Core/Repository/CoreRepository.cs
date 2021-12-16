using FapClient.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FapClient.Core.Repository
{
    public class CoreRepository<T> : ICoreRepository<T> where T : class
    {
        protected readonly AP2Context _context = new AP2Context();
        private readonly DbSet<T> dbSet;

        public CoreRepository()
        {
            var typeOfDbSet = typeof(DbSet<T>);
            foreach (var prop in _context.GetType().GetProperties())
            {
                if (typeOfDbSet == prop.PropertyType)
                {
                    dbSet = prop.GetValue(_context, null) as DbSet<T>;
                    break;
                }
            }

            if (dbSet == null)
            {
                dbSet = _context.Set<T>();
            }
        }

        public int Add(T entity)
        {
            dbSet.Add(entity);
            return _context.SaveChanges();
        }

        public int AddRange(List<T> entities)
        {
            dbSet.AddRange(entities);
            return _context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            dbSet.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            if (id > 0)
            {
                dbSet.Remove(GetById(id));
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetQuery()
        {
            return dbSet;
        }

        public IQueryable<T> GetQuery(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }

        public virtual bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
