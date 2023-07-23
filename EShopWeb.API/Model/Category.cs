using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Category
    {
        public int CatId { get; set; }
        public required string CatName { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }
        public int? Level { get; set; }
        public int? Ordering { get; set; }
        public Status Published { get; set; }
        public string? ThumbImage { get; set; }
        public string? Title { get; set; }
        public string? SeoAlias { get; set; }
        public string? MetaDesc { get; set; }
        public string? MetaKey { get; set; }
        public string? ImageCover { get; set; }
    }
}
