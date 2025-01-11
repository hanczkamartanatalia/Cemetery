using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidatorLib;

namespace ServicesLib.Services
{
    public class DeadService : Service<DeadService, Dead>, IValidate<Dead>
    {
        public bool Validate(Dead dead)
        {
            bool result = true;
            if (!BaseValidator.LengthValidator(dead.FirstName, 3, 20)) result = false;
            if (!BaseValidator.LengthValidator(dead.LastName, 3, 20)) result = false;
            if (!DateValidator.DateTimeBefore(dead.DateTimeDeath)) result = false;
            return result;
        }
    }
}
