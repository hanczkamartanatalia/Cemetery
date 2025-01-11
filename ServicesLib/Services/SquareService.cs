using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class SquareService : Service<SquareService>, ICrud<Square>
    {
        Square ICrud<Square>.Create(Square entity)
        {
            throw new NotImplementedException();
        }

        Square ICrud<Square>.Delete(Square entity)
        {
            throw new NotImplementedException();
        }

        Square ICrud<Square>.Read(Square entity)
        {
            throw new NotImplementedException();
        }

        Square ICrud<Square>.Update(Square entity)
        {
            throw new NotImplementedException();
        }
    }
}
