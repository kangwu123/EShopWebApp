using EShopWeb.SharedObject.Common;
namespace EShopWeb.API.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public required string OrderNo { get; set; }
        public Guid UserId { set; get; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Confirm Deleted { get; set; }
        public Confirm Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? Deatil { get; set; }
    }
}
