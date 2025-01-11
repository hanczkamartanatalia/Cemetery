using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLib.Interfaces;

namespace ServicesLib.Interfaces
{
    public interface ICrud<T> where T : IEntity
    {
        public T Create(T entity);
        public T Update(T entity);
        public T Delete(T entity);
        public T Read(T entity);


    }
}
