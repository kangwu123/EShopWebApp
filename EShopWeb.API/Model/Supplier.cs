using EShopWeb.SharedObject.Common;

namespace EShopWeb.API.Model
{
    public class Supplier : BaseEntity
    {
        public int Id { get; set; }
        public required string CompanyName { get; set; }
        public string? Logo { get; set; }
        public string? Note { get; set; }
        public string? WebUrl { get; set; }
        public required string Address { get; set;}
        public required string City { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? Region { get; set; }
        public string? PostCode { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string PaymentMethod { get; set; }
        public Confirm DiscountAvailabe { get; set; }
        public Guid UserId { get; set; }
    }
}
