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
        public  void Add(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
             dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public  void Add(TEntity entity)
        {
            _dbSet.Add(entity);
             dbcontext.SaveChangesAsync();
        }

        public  void Commit()
        {
             dbcontext.SaveChanges();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public  void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
             dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        public  void Delete(List<TEntity> entitys)
        {
            _dbSet.RemoveRange(entitys);
             dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public  void Delete(TKey key)
        {
            var entity = _dbSet.Find(key);
            if (entity != null)
                _dbSet.Remove(entity);
             dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public  void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            dbcontext.Entry<TEntity>(entity).State = EntityState.Modified;
             dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public  TEntity GetModel(Expression<Func<TEntity, bool>> whereLambda)
        {
            return  _dbSet.FirstOrDefault(whereLambda);
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public  TEntity GetModel(TKey key)
        {
            return  _dbSet.Find(key);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public  IList<TEntity> Select(Expression<Func<TEntity, bool>> whereLambda = null)
        {
            IList<TEntity> list;
            if (whereLambda == null)
            {
                list =  _dbSet.ToList();
                return list;
            }
            list =  _dbSet.Where(whereLambda).ToList();
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
        public  IList<TEntity> Select<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true)
        {
            IList<TEntity> list;
            if (whereLambda == null)
            {
                list =  _dbSet.ToList();
                return list;
            }
            if (isAsc && orderLambda != null)
                list =  _dbSet.Where(whereLambda).OrderBy(orderLambda).ToList();
            else if (orderLambda != null)
                list =  _dbSet.Where(whereLambda).OrderByDescending(orderLambda).ToList();
            else
                list =  _dbSet.Where(whereLambda).ToList();
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
