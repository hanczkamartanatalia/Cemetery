using EntitiesLib.Entities;
using ServicesLib.Interfaces;

namespace ServicesLib.Services
{
    public class OwnerHireService : Service<OwnerHireService, OwnerHire>, IValidate<OwnerHire>
    {
        public bool Validate(OwnerHire entity)
        {
            return true;
        }
    }
}
