﻿using EntitiesLib.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Funeral : Entity
    {
        public DateTime DateTime { get; set; }

        public FuneralStatus FuneralStatus { get; set; }
        public Square Square { get; set; } = default!;

        [ForeignKey("SquareId")]
        public int SquareId { get; set; }

        public Dead Dead { get; set; } = default!;

        [ForeignKey("DeadId")]
        public int DeadId { get; set; }


    }
}
