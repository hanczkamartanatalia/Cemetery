using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Employee : Person, IContact, IUser
    {
        string IContact.Phone { get; set; } = default!;
        string IContact.Email { get; set; } = default!;
        string IUser.Login { get; set; } = default!;
        byte[] IUser.Password { get; set; } = default!;
    }
}
