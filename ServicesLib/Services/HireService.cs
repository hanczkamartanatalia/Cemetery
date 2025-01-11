using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class HireService : Service<HireService>, ICrud<Hire>
    {
        Hire ICrud<Hire>.Create(Hire entity)
        {
            throw new NotImplementedException();
        }

        Hire ICrud<Hire>.Delete(Hire entity)
        {
            throw new NotImplementedException();
        }

        Hire ICrud<Hire>.Read(Hire entity)
        {
            throw new NotImplementedException();
        }

        Hire ICrud<Hire>.Update(Hire entity)
        {
            throw new NotImplementedException();
        }
    }
}
