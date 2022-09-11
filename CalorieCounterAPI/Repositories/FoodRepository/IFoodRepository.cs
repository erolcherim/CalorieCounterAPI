using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;

namespace CalorieCounterAPI.Repositories.FoodRepository
{
    public interface IFoodRepository: IGenericRepository<Food>
    {
        Task<Food> GetFoodByFoodName(string name);
        Task<List<Food>> GetFoodsContainingName(string name);
    }
}