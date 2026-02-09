using System;
using System.Collections.Generic;
using System.Linq;
static class ProductService                     
{
    public static void GroupAverage()
    {
        List<Product> products = new List<Product>
        {
             new Product { Name = "Laptop",  Category = "Electronics", Price = 60000 },
            new Product { Name = "Mobile",  Category = "Electronics", Price = 30000 },
            new Product { Name = "Shirt",   Category = "Clothing",    Price = 1500 },
            new Product { Name = "Jeans",   Category = "Clothing",    Price = 2500 },
            new Product { Name = "Rice",    Category = "Groceries",   Price = 1200 }
        };
        var result = products.GroupBy(p=> p.Category).Select(g=> new { Category = g.Key,AveragePrice = g.Average(p=>p.Price)});
   
      foreach (var item in result)
        {
            Console.WriteLine($"{item.Category} → Average Price: {item.AveragePrice}");
        }
   
    }

}