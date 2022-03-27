﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_01.Models
{
    public class OrderDetailViewModel
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public decimal? PriceDiscount { get; set; }
        public string Logo { get; set; }
        public string ProductName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
