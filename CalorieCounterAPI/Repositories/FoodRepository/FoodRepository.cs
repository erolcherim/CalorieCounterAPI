using CalorieCounterAPI.DAL;
using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CalorieCounterAPI.Repositories.FoodRepository
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        public FoodRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<Food>> GetFoodsContainingName(string name) =>
            await _context.Foods.Where(food => food.FoodName.Contains(name)).ToListAsync();

        public async Task<Food> GetFoodByFoodName(string name) =>
            await _context.Foods.Where(food => food.FoodName.Equals(name)).FirstOrDefaultAsync();

    }
}
