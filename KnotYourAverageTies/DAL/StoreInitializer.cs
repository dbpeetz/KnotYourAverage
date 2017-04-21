using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnotYourAverageTies.Models;

namespace KnotYourAverageTies.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var customer = new List<Customer>
            {
            new Customer { FirstName = "Donald", LastName = "Trump", LastPurchase = DateTime.Parse("2016-12-25") },
            new Customer { FirstName = "Ion", LastName = "Hazzikostas", LastPurchase = DateTime.Parse("2016-05-12") },
            new Customer { FirstName = "Michael", LastName = "Morhaime", LastPurchase = DateTime.Parse("2017-02-01") },
            new Customer { FirstName = "Benn", LastName = "Brode", LastPurchase = DateTime.Parse("2016-04-20") },
            new Customer { FirstName = "Mark", LastName = "Zuckerberg", LastPurchase = DateTime.Parse("2016-01-04") },
            new Customer { FirstName = "Bill", LastName = "Gates", LastPurchase = DateTime.Parse("2016-09-01") },
            };

            customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
              new Product {ProductID = 1, Name="Circuit Board", UPC=42342342321, Price=64.99m, SectionID="Custom Ties", Inventory=48},
              new Product {ProductID = 2, Name="Smooth Argyle", UPC=43423423423, Price=44.99m, SectionID="Standard Ties", Inventory=456},
              new Product {ProductID = 3, Name="A Flock of Seagulls", UPC=01423423423, Price=24.99m, SectionID="Bow Ties", Inventory=84},
              new Product {ProductID = 4, Name="The Einstein", UPC=17423423423, Price=34.99m, SectionID="Bow Ties", Inventory=36},
              new Product {ProductID = 5, Name="Classy", UPC=92423423423, Price=34.99m, SectionID="Skinny Ties", Inventory=72},
              new Product {ProductID = 6, Name="Skinny Polka", UPC=33423423423, Price=34.99m, SectionID="Skinny Ties", Inventory=126},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase { CustomerID=1, ProductID=1, Quantity=1 },
            new Purchase { CustomerID=2, ProductID=2, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=3, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=4, Quantity=4 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=5, ProductID=5, Quantity=1 },
            new Purchase { CustomerID=6, ProductID=6, Quantity=1 },

            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { EmployeeID=1, FirstName = "Devan", LastName = "Peetz", HireDate = DateTime.Parse("2012-05-16") },
                new Employee { EmployeeID=2, FirstName = "Karli", LastName = "Peetz", HireDate = DateTime.Parse("2012-05-16") },
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { DepartmentID = 1, Name = "Standard Ties", TotalSales = 120000 },
                new Department { DepartmentID = 2, Name = "Skinny Ties", TotalSales = 8000 },
                new Department { DepartmentID = 3, Name = "Bow Ties", TotalSales = 12000 },
                new Department { DepartmentID = 4, Name = "Custom Ties", TotalSales = 70000 }

            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var assignments = new List<Assignment>
            {
                new Assignment { EmployeeID = 1, DepartmentID = 1 },
                new Assignment { EmployeeID = 2, DepartmentID = 2 },

            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();


        }
    }
}