using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Yckj.YcFdyth.IRepository.BaseRepository;
using Yckj.YcFdyth.IService.IBaseService;

namespace Yckj.YcFdyth.Service.BaseService
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        public IBaseRepository<TEntity, int> CurrentRepository { get; set; }
        public void Add(List<TEntity> entities)
        {
            CurrentRepository.Add(entities);
        }

        public void Add(TEntity entity)
        {
            CurrentRepository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            CurrentRepository.Delete(entity);
        }

        public void Delete(List<TEntity> entitys)
        {
            CurrentRepository.Delete(entitys);
        }

        public void Delete(int key)
        {
            CurrentRepository.Delete(key);
        }

        public TEntity GetModel(Expression<Func<TEntity, bool>> whereLambda)
        {
            return CurrentRepository.GetModel(whereLambda);
        }

        public TEntity GetModel(int key)
        {
            return CurrentRepository.GetModel(key);
        }

        public IList<TEntity> Select(Expression<Func<TEntity, bool>> whereLambda = null)
        {
            return CurrentRepository.Select(whereLambda);
        }

        public IList<TEntity> Select<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true)
        {
            return CurrentRepository.Select(whereLambda, orderLambda, isAsc);
        }

        public IList<TEntity> SelectPageAsync<s>(int pageIndex, int pageSize, out int TotalCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, s>> orderLambda, bool isAsc)
        {
            return CurrentRepository.SelectPageAsync(pageIndex, pageSize, out TotalCount, whereLambda, orderLambda, isAsc);
        }

        public void Update(TEntity entity)
        {
            CurrentRepository.Update(entity);
        }
    }
}
