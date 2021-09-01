using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Threading.Tasks;

namespace App.Domain.UseCase.CarUseCase
{
    /// <summary>
    /// Save or Update Car
    /// </summary>
    public class Save
    {
        private readonly ICarRepository _repository;

        /// <summary>
        /// Constructor inversion controller
        /// </summary>
        /// <param name="repository"></param>
        public Save(ICarRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        ///    Execute Command
        /// </summary>
        /// <param name="car"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> Execute(Car car)
        {
            bool create = Guid.Empty != car?.Id;
            return await (create ? _repository.Save(car) : _repository.Update(car));
        }
    }
}
