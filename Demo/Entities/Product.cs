using System;
using System.Collections.Generic;


namespace Demo
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public int ProductUnit { get; set; }
        public decimal ProductCost { get; set; }
        public int  ProductDiscountMax { get; set; }
        public int ProductManufacturer { get; set; }
        public int ProductProvider { get; set; }
        public int ProductCategory { get; set; }
        public double? ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; } = null;
        public byte[] ProductPhoto { get; set; }
        public int ProductStatusStock { get; set; }

        public virtual ProductCategory ProductCategoryNavigation { get; set; } = null!;
        public virtual Manufacturer ProductManufacturerNavigation { get; set; } = null!;
        public virtual Provider? ProductProviderNavigation { get; set; }
        public virtual Unit ProductUnitNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
