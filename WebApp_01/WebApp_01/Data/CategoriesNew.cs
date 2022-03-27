﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_01.Data
{
    public partial class CategoriesNew
    {
        public CategoriesNew()
        {
            News = new HashSet<News>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ShowHome { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
