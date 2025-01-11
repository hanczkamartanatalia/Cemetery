using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Localization : IEntity
    {
        int IEntity.Id { get; set; }
        bool IEntity.IsDeleted { get; set; }

        public bool IsAccess { get; set; }
        public string Address { get; set; } = default!;
    }
}
