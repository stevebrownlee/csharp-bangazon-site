﻿using Bangazon.Models;
using System.Collections.Generic;

namespace BangazonAuth.Models
{
    public class GroupedProducts
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int ProductCount { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}