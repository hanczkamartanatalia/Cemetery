using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Localization : Entity
    {

        public bool IsAccess { get; set; }
        public string Address { get; set; } = default!;
    }
}
