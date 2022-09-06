using System.ComponentModel.DataAnnotations;

namespace CalorieCounterAPI.DAL.DTOs
{
    public class UserLoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
