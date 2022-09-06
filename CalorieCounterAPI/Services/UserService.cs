using CalorieCounterAPI.DAL.DTOs;
using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.DAL.Models.Constants;
using Microsoft.AspNetCore.Identity;

namespace CalorieCounterAPI.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<bool> RegisterUserAsync(UserRegisterDTO dto)
        {
            var registerUser = new User();

            registerUser.Email = dto.Email;
            registerUser.UserName = dto.Email;
            registerUser.FirstName = dto.FirstName;
            registerUser.LastName = dto.LastName;
            registerUser.Age = dto.Age;

            var result = await _userManager.CreateAsync(registerUser, dto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(registerUser, UserRoleType.User);

                return true;
            }

            return false;
        }
    }
}
