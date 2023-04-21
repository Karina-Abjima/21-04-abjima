using ProjectLinq.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinq.RepositoryClasses
{
    public partial class ProductRepository
    {
        public static List<Product>  GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductID = 680,
                    Name = "HL Road Frame",
                    Color = "Black",
                    StandardCost = 1059.31M,
                    ListPrice = 1431.50M,
                    Size = "58",
                },

                new Product
                {
                    ProductID = 690,
                    Name = "Huski Vuski",
                    Color = "Grey",
                    StandardCost = 1154.35M,
                    ListPrice = 1678.50M,
                    Size = "25",
                },

                new Product
                {
                    ProductID = 700,
                    Name = "Dawn Mover",
                    Color = "Sunrise Red",
                    StandardCost = 1200.55M,
                    ListPrice = 1934.46M,
                    Size = "68",
                },

                new Product
                {
                    ProductID = 710,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },

                new Product
                {
                    ProductID = 720,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },

                new Product
                {
                    ProductID = 730,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },

                new Product
                {
                    ProductID = 740,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },

                new Product
                {
                    ProductID = 750,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },

                new Product
                {
                    ProductID = 760,
                    Name = "High Table",
                    Color = "Wooden",
                    StandardCost = 5059.31M,
                    ListPrice = 7999.98M,
                    Size = "99",
                },


            };
        }
    }
}
