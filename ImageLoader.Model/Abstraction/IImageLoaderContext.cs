using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace ImageLoader.Model.Abstraction
{
    /// <summary>
    ///
    /// </summary>
    public interface IImageLoaderContext
    {
        /// <summary>
        ///
        /// </summary>
        Database Database { get; }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityType"></param>
        /// <returns></returns>
        DbSet Set(Type entityType);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<DbEntityValidationResult> GetValidationErrors();

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DbEntityEntry Entry(object entity);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}