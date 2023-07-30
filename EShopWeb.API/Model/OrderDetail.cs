using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int MyProperty { get; set; }
        //Foregin Key Table
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
