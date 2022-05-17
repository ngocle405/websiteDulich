using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppDulich.Data
{
    public partial class Order
    {
        public long Id { get; set; }
        public string OrderName { get; set; }
        public string OrderAddress { get; set; }
        public string OrderEmail { get; set; }
        public int OrderPhone { get; set; }
        public string OrderNote { get; set; }
        public decimal? TotalMoney { get; set; }
        public int? PaymentStatus { get; set; }
        public long TourId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
