using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class OwnerService : Service<OwnerService>, ICrud<Owner>
    {
        Owner ICrud<Owner>.Create(Owner entity)
        {
            throw new NotImplementedException();
        }

        Owner ICrud<Owner>.Delete(Owner entity)
        {
            throw new NotImplementedException();
        }

        Owner ICrud<Owner>.Read(Owner entity)
        {
            throw new NotImplementedException();
        }

        Owner ICrud<Owner>.Update(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
