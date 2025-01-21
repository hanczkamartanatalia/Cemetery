using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class FuneralEmployee : Entity
    {
        public Funeral Funeral { get; set; } = default!;
        public Funeral Employee { get; set; } = default!;

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        [ForeignKey("FuneralId")]
        public int FuneralId { get; set; }

    }
}
