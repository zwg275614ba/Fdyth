using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Yckj.YcFdyth.IService.IBaseService
{
    public interface IBaseService<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// 通过ID获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TEntity> GetModel(int key);
        /// <summary>
        /// 通过条件获取实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        Task<TEntity> GetModel(Expression<Func<TEntity, bool>> whereLambda);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(TEntity entity);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddAsync(List<TEntity> entities);
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync(TEntity entity);
        /// <summary>
        /// 主键删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task DeleteAsync(int key);
        /// <summary>
        /// 实体删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        Task DeleteAsync(List<TEntity> entitys);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="whereLambda">条件</param>
        /// <returns></returns>
        Task<IList<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> whereLambda = null);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="whereLambda">条件</param>
        /// <param name="orderLambda">排序</param>
        /// <param name="isAsc">true 升序 false 降序</param>
        /// <returns></returns>
        Task<IList<TEntity>> SelectAsync<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true);
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">行数</param>
        /// <param name="TotalCount">总条数</param>
        /// <param name="whereLambda">条件查询</param>
        /// <param name="orderLambda">排序</param>
        /// <param name="isAsc">true 升序 false 降序</param>
        /// <returns></returns>
        IList<TEntity> SelectPageAsync<s>(int pageIndex, int pageSize, out int TotalCount, Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, s>> orderLambda, bool isAsc);
    }
}
