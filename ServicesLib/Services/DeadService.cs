using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class DeadService : Service<DeadService>, ICrud<Dead>
    {
        Dead ICrud<Dead>.Create(Dead entity)
        {
            throw new NotImplementedException();
        }

        Dead ICrud<Dead>.Delete(Dead entity)
        {
            throw new NotImplementedException();
        }

        Dead ICrud<Dead>.Read(Dead entity)
        {
            throw new NotImplementedException();
        }

        Dead ICrud<Dead>.Update(Dead entity)
        {
            throw new NotImplementedException();
        }
    }
}
