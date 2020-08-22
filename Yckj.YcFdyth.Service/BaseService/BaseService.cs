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
        public async Task AddAsync(List<TEntity> entities)
        {
            await CurrentRepository.AddAsync(entities);
        }

        public async Task AddAsync(TEntity entity)
        {
            await CurrentRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await CurrentRepository.DeleteAsync(entity);
        }

        public async Task DeleteAsync(List<TEntity> entitys)
        {
            await CurrentRepository.DeleteAsync(entitys);
        }

        public async Task DeleteAsync(int key)
        {
            await CurrentRepository.DeleteAsync(key);
        }

        public async Task<TEntity> GetModel(Expression<Func<TEntity, bool>> whereLambda)
        {
            return await CurrentRepository.GetModel(whereLambda);
        }

        public async Task<TEntity> GetModel(int key)
        {
            return await CurrentRepository.GetModel(key);
        }

        public async Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> whereLambda = null)
        {
            return await CurrentRepository.SelectAsync(whereLambda);
        }

        public async Task<IList<TEntity>> SelectAsync<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true)
        {
            return await CurrentRepository.SelectAsync(whereLambda, orderLambda, isAsc);
        }

        public IList<TEntity> SelectPageAsync<s>(int pageIndex, int pageSize, out int TotalCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, s>> orderLambda, bool isAsc)
        {
            return CurrentRepository.SelectPageAsync(pageIndex, pageSize, out TotalCount, whereLambda, orderLambda, isAsc);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await CurrentRepository.UpdateAsync(entity);
        }
    }
}
