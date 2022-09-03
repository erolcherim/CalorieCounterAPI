using Microsoft.AspNetCore.Identity;

namespace CalorieCounterAPI.DAL.Models
{
    public class User : IdentityUser<int>
    {
        public int UserId { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; }
    }
}
