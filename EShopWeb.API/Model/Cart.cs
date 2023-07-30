using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Cart : BaseEntity
    {
        public int CartId { set; get; }
        public int ProductId { set; get; }
        public Guid UserId { get; set; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
    }
}
