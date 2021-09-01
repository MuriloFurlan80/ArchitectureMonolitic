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
    /// Get By Id
    /// </summary>
    public class GetById
    {
        private readonly IMotocycleRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public GetById(IMotocycleRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Execute Command
        /// </summary>
        /// <returns><see cref="Motocycle"/> /></returns>
        public async Task<Motocycle> Execute(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
}
