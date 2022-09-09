using NorthwindWithLinq.Models;

Console.WriteLine("Northwind with LINQ!");

NorthwindContext _context = new();

#region Supplier & Products

var suppliers = from s in _context.Suppliers
                join p in _context.Products
                    on s.SupplierId equals p.SupplierId
                orderby s.CompanyName
                select new {
                    Supplier = s.CompanyName, 
                    Product = p.ProductName,
                    Price = p.UnitPrice,
                    Units = p.UnitsInStock,
                    InventoryCost = p.UnitsInStock * p.UnitPrice
                };

foreach(var s in suppliers) {
    Console.WriteLine($"{s.Supplier,-40} | {s.Product,-35} | {s.InventoryCost,15:C}");
}

Console.WriteLine($"Total Inventory Cost : {suppliers.Sum(s => s.InventoryCost),20:C}");

#endregion

/*
 
int i = 1;

string iStr = i.ToString();


var products = _context.Products.ToList();

products.ForEach(p => Console.WriteLine(p));


var employees = from empl in _context.Employees
                where !empl.Country.ToUpper().Equals("Usa".ToUpper())
                orderby empl.LastName
                select empl;

foreach(Employee e in employees) {
    Console.WriteLine($"{e.FirstName} {e.LastName} | {e.Country}");
}

*/