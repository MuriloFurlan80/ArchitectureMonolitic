using App.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace App.Data.Repository
{
    /// <summary>
    /// Repository Generic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T>
    {
        List<T> db = new();

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns>List <typeparamref name="T"/></returns>
        /// <returns><see cref="Nullable"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<IEnumerable<T>> GetAsync()
        {
            List<T> list = new();
            var jsonString = File.ReadAllText("db.txt");
            list.Add(JsonSerializer.Deserialize<T>(jsonString));
            return await Task.FromResult(list);
        }

        /// <summary>
        /// Get Id Guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List <typeparamref name="T"/></returns>
        /// <returns><see cref="Nullable"/></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="entity"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public Task<bool> Save(T entity)
        {
            var json = JsonSerializer.Serialize(entity);
            File.WriteAllText("db.txt", json);
            return Task.FromResult(true);
        }

        /// <summary>
        ///  Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns><see cref="Boolean"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public Task<bool> Update(T entity)
        {
            var json = JsonSerializer.Serialize(entity);
            File.WriteAllText("db.txt", json);
            return Task.FromResult(true);
        }
    }
}
