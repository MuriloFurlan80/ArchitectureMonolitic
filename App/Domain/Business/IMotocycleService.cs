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
    public interface IMotocycleService
    {

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="motocycle"></param>
        /// <returns></returns>
        Task<bool> Save(Motocycle motocycle);

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Motocycle>> Get();
    }
}
