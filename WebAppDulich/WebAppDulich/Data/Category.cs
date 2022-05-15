using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppDulich.Data
{
    public partial class Category
    {
        public Category()
        {
            Tours = new HashSet<Tour>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ShowHome { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
