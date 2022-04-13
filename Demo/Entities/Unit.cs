using System;
using System.Collections.Generic;

#nullable disable

namespace Demo
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }

        public int UnitId { get; set; }
        public string UnutName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
