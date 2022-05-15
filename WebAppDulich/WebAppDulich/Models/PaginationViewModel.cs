﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDulich.Models
{
    public class PaginationViewModel
    {
        public long TotalItems { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public dynamic Data { get; set; }
    }
}
