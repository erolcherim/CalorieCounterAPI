using System.ComponentModel.DataAnnotations;

namespace CalorieCounterAPI.DAL.DTOs
{
    public class UserLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
