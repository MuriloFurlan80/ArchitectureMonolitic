using App.Data.Repository;
using App.Domain.Business;
using App.Domain.Model;
using App.Domain.Repository;
using App.Domain.UseCase.CarUseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    /// <summary>
    /// Service Car Class
    /// </summary>
    public class CarService : ICarService
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Car>> Get()
        {
            Get get = new(new CarRepository());
            return await get.Execute();
        }

        /// <summary>
        /// Save 
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public async Task<bool> Save(Car car)
        {
            Save save = new(new CarRepository());
            return await save.Execute(car);
        }
    }
}
