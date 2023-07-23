using EShopWeb.SharedObject.Common;
using Microsoft.AspNetCore.Identity;
#nullable disable
namespace EShopWeb.API.Model
{
    public class AppUser :IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTimeOffset LastLogin { get; set; }
        public Status LoginStatus { get; set; }
    }
}
