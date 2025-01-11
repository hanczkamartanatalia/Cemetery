using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Interfaces
{
    public interface IUser
    {
        public string Login { get; set; }
        public byte[] Password { get; set; }
    }
}
