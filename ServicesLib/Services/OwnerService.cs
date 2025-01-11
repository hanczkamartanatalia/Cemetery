using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class OwnerService : Service<OwnerService, Owner>, IValidate<Owner>
    {
        public bool Validate(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
