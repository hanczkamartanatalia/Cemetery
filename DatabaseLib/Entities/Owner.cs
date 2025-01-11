using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Owner : Person, IContact
    {
        public string Phone { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
