using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Domain.Repository
{
    /// <summary>
    /// Repository Contract
    /// </summary>
    public interface IRepository<T> : IRepositoryBase
    {
        /// <summary>
        /// Save 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        Task<bool> Save(T entity);


        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        Task<bool> Update(T entity);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        Task<bool> Delete(Guid id);

        /// <summary>
        /// Get Id Guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List <typeparamref name="T"/></returns>
        /// <returns><see cref="Nullable"/></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns>List <typeparamref name="T"/></returns>
        /// <returns><see cref="Nullable"/></returns>
        /// <exception cref="ArgumentException"></exception>
        Task<IEnumerable<T>> GetAsync();
    }
}
