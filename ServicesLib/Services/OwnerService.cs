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
    public class OwnerService : Service<OwnerService, Owner>, IValidate<Owner>
    {
        public bool Validate(Owner entity)
        {
            bool result = true;
            if (!BaseValidator.LengthValidator(entity.FirstName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            if (!BaseValidator.LengthValidator(entity.LastName, ParamsConfig.MIN_LENGTH_NAME, ParamsConfig.MAX_LENGTH_NAME)) result = false;
            if (!ContactValidator.IsValidEmail(entity.Email)) result = false;
            if (!ContactValidator.IsValidPhoneNumber(entity.Phone)) result = false;
            return result;
        }
    }
}
