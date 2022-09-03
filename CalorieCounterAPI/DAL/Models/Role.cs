using Microsoft.AspNetCore.Identity;

namespace CalorieCounterAPI.DAL.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
