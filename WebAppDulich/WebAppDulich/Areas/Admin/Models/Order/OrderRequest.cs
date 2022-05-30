using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDulich.Areas.Admin.Models.Order
{
    public class OrderRequest
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
        public string TourName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
