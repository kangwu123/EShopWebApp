using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class ProductsMedia :BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? ImagePath { get; set; }
        public string? VideoPath { get; set; }
        public string? Caption { get; set; }
        public Confirm IsDefault { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
    }
}
