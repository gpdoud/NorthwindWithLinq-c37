using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models {
    
    public class Supplier {

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

        public override string ToString() {
            return
                $"{SupplierId,5} | {CompanyName,-30} | {ContactName,-30} | {Region,-15} | {Country,-15}";
        }
    }
}
