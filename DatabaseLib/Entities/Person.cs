using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public abstract class Person : IEntity, IPersonality
    {
        int IEntity.Id { get; set; }
        bool IEntity.IsDeleted { get; set; }
        string IPersonality.FirstName { get; set; } = default!;
        string IPersonality.LastName { get; set; } = default!;
    }
}
