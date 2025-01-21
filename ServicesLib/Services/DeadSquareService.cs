using EntitiesLib.Entities;
using ServicesLib.Interfaces;

namespace ServicesLib.Services
{
    public class DeadSquareService : Service<DeadSquareService, DeadSquare>, IValidate<DeadSquare>
    {
        public bool Validate(DeadSquare entity)
        {
            return true;
        }
    }
}
