using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CMMS3.Infrastructure
{
    public interface IRepasitoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll(bool trucking);
        IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression, bool trucking);

    }

    public abstract class RepasitoryBase<TEntity> : IRepasitoryBase<TEntity> , IDisposable where TEntity : class
    {
        private readonly DbContext _context;

        private DbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        public RepasitoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll(bool trucking)
        {
            return trucking ?  DbSet.AsTracking().AsEnumerable(): DbSet.AsNoTracking().AsEnumerable();
        }

        public IEnumerable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression, bool trucking)
        {
            return trucking ? DbSet.Where(expression).AsTracking().AsEnumerable():DbSet.Where(expression).AsNoTracking().AsEnumerable();
        }


        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this._disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}