using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SemicolonShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductUnit { get; set; }
        public string DateUpdate { get; set; }
    }
}
