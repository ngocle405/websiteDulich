﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_01.Data
{
    public partial class Promotion
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Link { get; set; }
        public int? Status { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
