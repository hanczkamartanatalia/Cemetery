﻿using EntitiesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLib.Entities
{
    public class Hire : IEntity
    {
        int IEntity.Id { get; set; }
        bool IEntity.IsDeleted { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public decimal Amount { get; set; }
    }
}
