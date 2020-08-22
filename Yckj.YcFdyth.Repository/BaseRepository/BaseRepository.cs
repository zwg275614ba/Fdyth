using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Yckj.YcFdyth.IRepository.BaseRepository;
using Yckj.YcFdyth.Model;

namespace Yckj.YcFdyth.Repository.BaseRepository
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class, new()
    {
        /// <summary>
        /// 获取EF上下文
        /// </summary>
        DbContext dbcontext
        {
            get
            {
                DbContext dbcontext = CallContext.GetData("dbcontext") as DbContext;
                if (dbcontext == null)
                {
                    dbcontext = new YcFdythModel();
                    CallContext.SetData("dbcontext", dbcontext);
                }
                return dbcontext;
            }
        }
        private DbSet<TEntity> _dbSet;
        public BaseRepository()
        {
            _dbSet = dbcontext.Set<TEntity>();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task AddAsync(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await dbcontext.SaveChangesAsync();
        }

        public async Task Commit()
        {
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        public async Task DeleteAsync(List<TEntity> entitys)
        {
            _dbSet.RemoveRange(entitys);
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task DeleteAsync(TKey key)
        {
            var entity = _dbSet.Find(key);
            if (entity != null)
                _dbSet.Remove(entity);
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Attach(entity);
            dbcontext.Entry<TEntity>(entity).State = EntityState.Modified;
            await dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<TEntity> GetModel(Expression<Func<TEntity, bool>> whereLambda)
        {
            return await _dbSet.FirstOrDefaultAsync(whereLambda);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TEntity> GetModel(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> whereLambda = null)
        {
            IList<TEntity> list;
            if (whereLambda == null)
            {
                list = await _dbSet.ToListAsync();
                return list;
            }
            list = await _dbSet.Where(whereLambda).ToListAsync();
            return list;
        }
        /// <summary>
        /// 获取列表排序
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public async Task<IList<TEntity>> SelectAsync<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true)
        {
            IList<TEntity> list;
            if (whereLambda == null)
            {
                list = await _dbSet.ToListAsync();
                return list;
            }
            if (isAsc && orderLambda != null)
                list = await _dbSet.Where(whereLambda).OrderBy(orderLambda).ToListAsync();
            else if (orderLambda != null)
                list = await _dbSet.Where(whereLambda).OrderByDescending(orderLambda).ToListAsync();
            else
                list = await _dbSet.Where(whereLambda).ToListAsync();
            return list;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="TotalCount"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IList<TEntity> SelectPageAsync<s>(int pageIndex, int pageSize, out int TotalCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, s>> orderLambda, bool isAsc)
        {
            IQueryable<TEntity> temp = _dbSet.Where(whereLambda);
            TotalCount = temp.Count();
            IList<TEntity> list;
            if (isAsc)
            {
                list = temp.OrderBy<TEntity, s>(orderLambda).Skip<TEntity>((pageIndex - 1) * pageSize).Take<TEntity>(pageSize).ToList();
            }
            else
            {
                list = temp.OrderByDescending<TEntity, s>(orderLambda).Skip<TEntity>((pageIndex - 1) * pageSize).Take<TEntity>(pageSize).ToList();
            }
            return list;
        }
    }
}
