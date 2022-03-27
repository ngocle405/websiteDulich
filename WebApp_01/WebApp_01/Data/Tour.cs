using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_01.Data
{
    public partial class Tour
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? CategoryId { get; set; }
        public long? PlaceId { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceDiscount { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Status { get; set; }
        public string Destination { get; set; }
        public string DeparturePoint { get; set; }
        public DateTime Start { get; set; }
        public string Vehicle { get; set; }
        public string PlaceName { get; set; }
        public string Time { get; set; }

        public virtual Category Category { get; set; }
        public virtual Place Place { get; set; }
    }
}
