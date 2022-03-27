namespace WebApp_01.Areas.Admin.Models.Order
{
    public class StatusRequest
    {
        public long Id { get; set; }
        public int? PaymentStatus { get; set; }
    }
}
