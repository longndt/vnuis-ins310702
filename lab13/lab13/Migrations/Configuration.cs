namespace lab13.Migrations
{
    using lab13.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lab13.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "lab13.Models.ApplicationDbContext";
        }

        protected override void Seed(lab13.Models.ApplicationDbContext context)
        {
            //add initial data using Seed method

            //Seed categories
            var categories = new List<Category>
        {
            new Category { CategoryName = "Electronics" },
            new Category { CategoryName = "Clothing" },
            new Category { CategoryName = "Kitchen" }
        };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            // Seed products
            var products = new List<Product>
        {
            new Product { ProductName = "Demo Television", ProductPrice = 1200.00, CategoryId = categories.Single(c => c.CategoryName == "Electronics").CategoryId ,
               ProductImage = "https://static.digit.in/product/62fbd1bbab2478964564641957db61ce84794b94.jpeg"
            },
            new Product { ProductName = "Demo Jacket", ProductPrice = 999.95, CategoryId = categories.Single(c => c.CategoryName == "Clothing").CategoryId ,
              ProductImage = "https://www.stormtech.ca/cdn/shop/products/AFP-2_FRONT_HOOD_UP_Navy_Graphite_2000x.jpg?v=1687455758"
            },

            new Product { ProductName = "Demo Blender", ProductPrice = 599.99, CategoryId = categories.Single(c => c.CategoryName == "Kitchen").CategoryId ,
            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0OM6ooYMkeBoreH3k79PHeI3KPqvDWSu5B7lkNr3RYw&s"
            }
        };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
