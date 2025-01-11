using EntitiesLib.Entities;
using ServicesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLib.Services
{
    public class FuneralService : Service<FuneralService>, ICrud<Funeral>
    {
        Funeral ICrud<Funeral>.Create(Funeral entity)
        {
            throw new NotImplementedException();
        }

        Funeral ICrud<Funeral>.Delete(Funeral entity)
        {
            throw new NotImplementedException();
        }

        Funeral ICrud<Funeral>.Read(Funeral entity)
        {
            throw new NotImplementedException();
        }

        Funeral ICrud<Funeral>.Update(Funeral entity)
        {
            throw new NotImplementedException();
        }
    }
}
