using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class LocalizationService : Service<LocalizationService>, ICrud<Localization>
    {
        Localization ICrud<Localization>.Create(Localization entity)
        {
            throw new NotImplementedException();
        }

        Localization ICrud<Localization>.Delete(Localization entity)
        {
            throw new NotImplementedException();
        }

        Localization ICrud<Localization>.Read(Localization entity)
        {
            throw new NotImplementedException();
        }

        Localization ICrud<Localization>.Update(Localization entity)
        {
            throw new NotImplementedException();
        }
    }
}
