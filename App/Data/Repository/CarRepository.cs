using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    /// <summary>
    /// CarRepository Concrete
    /// </summary>
    public class CarRepository: Repository<Car>, ICarRepository
    {
    }
}
