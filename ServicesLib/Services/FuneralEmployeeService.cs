using EntitiesLib.Entities;
using ServicesLib.Interfaces;

namespace ServicesLib.Services
{
    public class FuneralEmployeeService : Service<FuneralEmployeeService, FuneralEmployee>, IValidate<FuneralEmployee>
    {
        public bool Validate(FuneralEmployee entity)
        {
            return true;
        }
    }
}
