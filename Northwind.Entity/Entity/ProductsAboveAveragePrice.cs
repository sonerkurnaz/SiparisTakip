using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Entity
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
