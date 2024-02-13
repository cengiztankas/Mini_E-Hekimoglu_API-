﻿using E_HekimogluAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_HekimogluAPI.Domain.Entities
{
    public class Beden:BaseEntity
    {
        public string Name { get; set; }
        public string No { get; set; }
        public bool? IsApproved { get; set; }
        public List<Product>? Products { get; set; }
    }
}
