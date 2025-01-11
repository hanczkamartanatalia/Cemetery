using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class SquareService : Service<SquareService, Square>, IValidate<Square>
    {
        public bool Validate(Square entity)
        {
            throw new NotImplementedException();
        }
    }
}
