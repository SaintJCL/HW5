using Microsoft.AspNetCore.Identity;
namespace Homework5.Models
{
    public class UserModel: IdentityUser
    {
        public string? Zodiac { get; set; }
    }
}
