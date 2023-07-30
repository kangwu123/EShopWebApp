using EShopWeb.SharedObject.Common;
namespace EShopWeb.API.Model
{
    public class Promotion : BaseEntity
    {
        public int Id { get; set; }
        public required string Condition { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? DiscountPercent { get; set; }
        public int? DiscountAmount { get; set; }
        public Status DiscountStatus { get; set; }
    }
}
