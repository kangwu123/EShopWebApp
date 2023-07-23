namespace EShopWeb.API.Model
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        //Foregin Key Table
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
