﻿using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public abstract class Person : Entity, IPersonality
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
