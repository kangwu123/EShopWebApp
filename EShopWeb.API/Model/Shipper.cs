namespace EShopWeb.API.Model
{
    public class Shipper
    {
        public int ShipperId { get; set; }
        public required string ShipperName { get; set; }
        public required string CompanyName { get; set; }
        public required string PhoneNo { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}
