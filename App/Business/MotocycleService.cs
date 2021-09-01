using App.Data.Repository;
using App.Domain.Business;
using App.Domain.Model;
using App.Domain.Repository;
using App.Domain.UseCase.MotocycleUseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Business
{
    /// <summary>
    /// Service Motocycle Class
    /// </summary>
    public class MotocycleService : IMotocycleService
    { 
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Motocycle>> Get()
        {
            Get get = new(new MotocycleRepository());
            return await get.Execute();
        }
        /// <summary>
        /// Save 
        /// </summary>
        /// <param name="motocycle"></param>
        /// <returns></returns>
        public async Task<bool> Save(Motocycle motocycle)
        {
            Save save = new(new MotocycleRepository());
            return await save.Execute(motocycle);
        }
    }
}
