using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class ProductCategory : BaseEntity
    {
        public int ProductId { get; set; }
        public int CatId { get; set; }
        //The Middle Table link with Foreign Key
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}

