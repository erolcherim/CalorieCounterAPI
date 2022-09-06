using Microsoft.AspNetCore.Identity;

namespace CalorieCounterAPI.DAL.Models
{
    public class User : IdentityUser<int>
    {
        public User() : base() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
