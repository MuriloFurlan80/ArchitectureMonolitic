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
    /// Delete Car
    /// </summary>
    public class Delete
    {
        private readonly ICarRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public Delete(ICarRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        ///    Execute Command
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Execute(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}
