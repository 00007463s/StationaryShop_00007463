using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationaryShop.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int QuantityAvailable { get; set; }

        public string CountryOfProduction { get; set; }

        public Category ProductCategory { get; set; }
    }
}
