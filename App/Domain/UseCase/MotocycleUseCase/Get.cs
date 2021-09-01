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
    /// Get All Motocycle
    /// </summary>
    public class Get
    {
        private readonly IMotocycleRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public Get(IMotocycleRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Execute Command
        /// </summary>
        /// <returns>List <see cref="Motocycle"/> /></returns>
        public async Task<IEnumerable<Motocycle>> Execute()
        {
            return await _repository.GetAsync();
        }
    }
}
