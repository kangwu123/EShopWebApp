using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string SKU { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int Quantity { set; get; }
        public Confirm ProductStatus { get; set; }
        public DateTime DateCreated { set; get; }
        public Confirm IsFeatured { get; set; }
        public int ViewCount { set; get; }
        public int  ProductCatId { get; set; }
        public required string SeoAlias { get; set; }
    }
}
