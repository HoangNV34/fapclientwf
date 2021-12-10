using FapClient.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Service.BaseServices
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual int Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork.CoreRepository<TEntity>().Add(entity);
            return _unitOfWork.SaveChanges();
        }

        public int AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                if (item == null)
                {
                    throw new ArgumentNullException();
                }
                _unitOfWork.CoreRepository<TEntity>().Add(item);
            }
            return _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var entity = _unitOfWork.CoreRepository<TEntity>().GetById(id);
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork.CoreRepository<TEntity>().Delete(entity);
            return _unitOfWork.SaveChanges() > 0;
        }

        public bool Delete(TEntity entity)
        {
            _unitOfWork.CoreRepository<TEntity>().Delete(entity);
            return _unitOfWork.SaveChanges() > 0;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _unitOfWork.CoreRepository<TEntity>().GetQuery().ToList();
        }

        public TEntity GetById(int id)
        {
            return _unitOfWork.CoreRepository<TEntity>().GetById(id);
        }

        public bool Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork.CoreRepository<TEntity>().Update(entity);
            return _unitOfWork.SaveChanges() > 0;
        }
    }
}
