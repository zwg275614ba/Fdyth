﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Yckj.YcFdyth.IRepository.BaseRepository
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class, new()
    {
        /// <summary>
        /// 通过ID获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity GetModel(Tkey key);
        /// <summary>
        /// 通过条件获取实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        TEntity GetModel(Expression<Func<TEntity, bool>> whereLambda);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Add(TEntity entity);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        void Add(List<TEntity> entities);
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(TEntity entity);
        /// <summary>
        /// 主键删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        void Delete(Tkey key);
        /// <summary>
        /// 实体删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Delete(TEntity entity);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        void Delete(List<TEntity> entitys);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="whereLambda">条件</param>
        /// <returns></returns>
        IList<TEntity> Select(Expression<Func<TEntity, bool>> whereLambda = null);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="whereLambda">条件</param>
        /// <param name="orderLambda">排序</param>
        /// <param name="isAsc">true 升序 false 降序</param>
        /// <returns></returns>
        IList<TEntity> Select<s>(Expression<Func<TEntity, bool>> whereLambda = null, Expression<Func<TEntity, s>> orderLambda = null, bool isAsc = true);
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
        /// <summary>
        /// 提交EF上下文
        /// </summary>
        /// <returns></returns>
        void Commit();
    }
}
