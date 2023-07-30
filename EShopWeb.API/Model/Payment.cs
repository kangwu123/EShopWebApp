using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Payment : BaseEntity
    {
        public int PaymentId { get; set; }
        public required string PaymentType { get; set; }
        public Confirm IsAllowed { get; set; }
    }
}
