﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_1.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string img { get; set; }

        public string ShopCartId { get; set; }
    }
}
