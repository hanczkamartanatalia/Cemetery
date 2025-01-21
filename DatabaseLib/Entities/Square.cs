using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Square : Entity
    {
        public int MaxDead { get; set; }

        public Localization Localization { get; set; } = default!;

        [ForeignKey("LocalizationId")]
        public int LocalizationId { get; set; }

    }
}
