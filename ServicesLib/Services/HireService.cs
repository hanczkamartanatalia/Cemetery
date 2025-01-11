using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class HireService : Service<HireService, Hire>, IValidate<Hire>
    {
        public bool Validate(Hire hire)
        {
            throw new NotImplementedException();
        }
    }
}
