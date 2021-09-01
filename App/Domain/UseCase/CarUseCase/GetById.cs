using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.UseCase.CarUseCase
{
    /// <summary>
    /// Get By Id
    /// </summary>
    public class GetById
    {
        private readonly ICarRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public GetById(ICarRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Execute Command
        /// </summary>
        /// <returns><see cref="Car"/> /></returns>
        public async Task<Car> Execute(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
