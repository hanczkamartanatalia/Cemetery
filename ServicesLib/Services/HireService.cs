using EntitiesLib.Entities;
using ServicesLib.Config;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidatorLib;

namespace ServicesLib.Services
{
    public class HireService : Service<HireService, Hire>, IValidate<Hire>
    {
        public bool Validate(Hire hire)
        {
            bool result = true;
            if (!DateValidator.IsDateAfter(hire.DateEnd)) result = false;
            return result;
        }
    }
}
