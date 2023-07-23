namespace EShopWeb.API.Model
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CatId { get; set; }
        //The Middle Table link with Foreign Key
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}

