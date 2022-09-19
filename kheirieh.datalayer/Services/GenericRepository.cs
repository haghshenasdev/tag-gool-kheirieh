using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private app_kheiriehEntities _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(app_kheiriehEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual TEntity GetByID(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null,int limit = 0 )
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            if (limit != 0)
            {
                query = query.Take(limit);
            }
            return query.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Deleted)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetByID(Id);
            Delete(entity);
        }

        public virtual TEntity GetRandom()
        {
            Random rnd = new Random();
            int toskip = rnd.Next(0,_dbSet.Count());
            return Get().Skip(toskip).Take(1).First();
        } 

        public virtual int CountOfData()
        {
            return _dbSet.Count();
        }

        
    }
}
