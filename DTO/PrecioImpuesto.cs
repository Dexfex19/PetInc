﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class PrecioImpuesto : BaseClass
    {
        public decimal PrecioBase { get; set; }
        public decimal DescuentoPaquete { get; set; }
        public decimal Impuesto { get; set; }
    }
}
