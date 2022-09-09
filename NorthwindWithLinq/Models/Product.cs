using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models {
    
    public class Product {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public string ProductIdName() {
            return $"ProductId      : {ProductId}\n" +
                   $"ProductName    : {ProductName}\n";
        }

        public override string ToString() {
            return $"ProductId      : {ProductId}\n" +
                   $"ProductName    : {ProductName}\n" +
                   $"UnitPrice      : {UnitPrice:C}\n";
        }
    }
}
