using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class FuneralService : Service<FuneralService, Funeral>, IValidate<Funeral>
    {
        public bool Validate(Funeral funeral)
        {
            throw new NotImplementedException();
        }
    }
}
