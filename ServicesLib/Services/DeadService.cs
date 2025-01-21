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
    public class DeadService : Service<DeadService, Dead>, IValidate<Dead>
    {
        public bool Validate(Dead dead)
        {
            bool result = true;
            if (!BaseValidator.LengthValidator(dead.FirstName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            if (!BaseValidator.LengthValidator(dead.LastName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            if (!DateValidator.IsDateTimeBefore(dead.DateTimeDeath)) result = false;
            return result;
        }
    }
}
