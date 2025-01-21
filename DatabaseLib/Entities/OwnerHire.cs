using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class OwnerHire : Entity
    {
        public Owner Owner { get; set; } = default!;
        public Hire Hire { get; set; } = default!;

        [ForeignKey("HireId")]
        public int HireId { get; set; }

        [ForeignKey("OwnerId")]
        public int OwnerId { get; set; }

    }
}
