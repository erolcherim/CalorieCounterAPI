using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;

namespace CalorieCounterAPI.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserAndUserRoleById(int userId);
        Task<User> GetUserByEmail(string email);
    }
}
