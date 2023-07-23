using EShopWeb.SharedObject.Common;
namespace EShopWeb.API.Model
{
    public class Blog
    {
        public int PostId { get; set; }
        public required string  TitleName { get; set; }
        public string? ShortDescription { get; set; }
        public required string ThumbImage { get; set; }
        public DateTime? CreateDate { get; set; }
        public required string  Author { get; set; }
        public string? Tag { get; set; }
        public Confirm Published { get; set; }
        public Confirm IsHot { get; set; }
        public Confirm IsNewfeed { get; set; }
        public int? ViewsCount { get; set; }
        public string? SeoAlias { get; set; }
        public required string MetaKey { get; set; }
        public required string MetaDesc { get; set; }
        public Guid UserId { get; set; }
    }
}
