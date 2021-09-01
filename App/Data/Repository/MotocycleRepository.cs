using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{  /// <summary>
   /// MotocycleRepository Concrete
   /// </summary>
    public class MotocycleRepository : Repository<Motocycle>, IMotocycleRepository
    {
    }
}
