using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class DeadSquare : Entity
    {
        public Dead Dead { get; set; } = default!;
        public Square Square { get; set; } = default!;

        [ForeignKey("DeadId")]
        public int DeadId { get; set; }

        [ForeignKey("SquareId")]
        public int SquareId { get; set; }
    }
}
