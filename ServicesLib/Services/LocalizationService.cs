using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class LocalizationService : Service<LocalizationService, Localization>, IValidate<Localization>
    {
        public bool Validate(Localization localization)
        {
            throw new NotImplementedException();
        }
    }
}
