using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Fields

        protected DbContext _dbContext;
        #endregion

        #region Properties
        protected DbSet<TEntity> _dataBase
        {
            get
            {
                return _dbContext.Set<TEntity>();
            }
        }
        #endregion

        #region Ctors
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Methods
        public TEntity Get(int id)
        {
            return _dataBase.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dataBase.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataBase.Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dataBase.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _dataBase.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dataBase.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _dataBase.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dataBase.RemoveRange(entities);
        }

        #region Async
        public async Task<TEntity> GetAsync(int id)
        {
            return await _dataBase.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dataBase.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dataBase.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dataBase.SingleOrDefaultAsync(predicate);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dataBase.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dataBase.AddRangeAsync(entities);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dataBase.Remove(entity);
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _dataBase.RemoveRange(entities);
        }
        #endregion
        #endregion
    }
}
