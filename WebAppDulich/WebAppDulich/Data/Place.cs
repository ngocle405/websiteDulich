using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppDulich.Data
{
    public partial class Place
    {
        public Place()
        {
            Tours = new HashSet<Tour>();
        }

        public long Id { get; set; }
        public string PlaceName { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Area { get; set; }
        public bool? ShowHome { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }
    }
}
