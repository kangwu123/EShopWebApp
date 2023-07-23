using Microsoft.AspNetCore.Identity;
namespace EShopWeb.API.Model
{
    public class AppRole :IdentityRole<Guid>
    {
        public required string Description { get; set; } 
    }
}
