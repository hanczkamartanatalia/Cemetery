using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Funeral : IEntity
    {
        int IEntity.Id { get; set; }
        bool IEntity.IsDeleted { get; set; }
        public DateTime DateTime { get; set; }
    }
}
