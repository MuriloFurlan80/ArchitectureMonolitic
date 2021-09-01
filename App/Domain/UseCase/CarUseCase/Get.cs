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
    /// Get All Car
    /// </summary>
    public class Get
    {
        private readonly ICarRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public Get(ICarRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Execute Command
        /// </summary>
        /// <returns>List <see cref="Car"/> /></returns>
        public async Task<IEnumerable<Car>> Execute()
        {
            return await _repository.GetAsync();
        }
    }
}
