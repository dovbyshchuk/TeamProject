using DAL.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeds
{
    public class DataSeader
    {
        public static void SeedProducts(MainDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                new Product {}
                //....
                };
                context.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
