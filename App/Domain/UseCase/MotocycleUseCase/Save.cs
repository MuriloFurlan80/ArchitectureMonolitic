using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UseCase.MotocycleUseCase
{
    /// <summary>
    /// Save or Update Motocycle
    /// </summary>
    public class Save
    {
        private readonly IMotocycleRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public Save(IMotocycleRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        ///    Execute Command
        /// </summary>
        /// <param name="motocycle"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Execute(Motocycle motocycle)
        {
            bool create = Guid.Empty != motocycle?.Id;
            return await (create ? _repository.Save(motocycle) : _repository.Update(motocycle));
        }
    }
}
