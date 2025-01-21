using EntitiesLib.Entities;
using ServicesLib.Config;
using ServicesLib.Interfaces;
using ValidatorLib;

namespace ServicesLib.Services
{
    public class LocalizationService : Service<LocalizationService, Localization>, IValidate<Localization>
    {
        public bool Validate(Localization localization)
        {
            bool result = true;
            if (!BaseValidator.LengthValidator(localization.Address, ParamsConfig.MIN_LENGTH_ADDRESS, ParamsConfig.MAX_LENGTH_ADDRESS)) result = false;
            return result;
        }
    }
}
