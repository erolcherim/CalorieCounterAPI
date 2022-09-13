using CalorieCounterAPI.DAL;
using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CalorieCounterAPI.Repositories.UserFoodRepository
{
    public class UserFoodRepository : GenericRepository<UserFood>, IUserFoodRepository
    {
        public UserFoodRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<UserFood>> GetAll() =>
            await _context.UserFoods.ToListAsync();

        public async Task<List<UserFood>> GetAllByUserId(int id) =>
            await _context.UserFoods.Where(uf => uf.UserId.Equals(id)).ToListAsync();
    }
}
