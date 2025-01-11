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
        string IContact.Phone { get; set; } = default!;
        string IContact.Email { get; set; } = default!;
    }
}
