﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
