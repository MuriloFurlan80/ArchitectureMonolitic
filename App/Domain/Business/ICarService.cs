using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Business
{
    /// <summary>
    /// ICarService business logic
    /// </summary>
    public interface ICarService
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Task<bool> Save(Car car);

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Car>> Get();
    }
}
