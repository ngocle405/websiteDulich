﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_01.Models
{
    public class CartItemViewModel
    {
        public long ProductId { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public decimal? Price { get; set; }
    }
}
