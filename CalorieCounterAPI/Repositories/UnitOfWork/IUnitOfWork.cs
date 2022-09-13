using CalorieCounterAPI.Repositories.FoodRepository;
using CalorieCounterAPI.Repositories.UserFoodRepository;
using CalorieCounterAPI.Repositories.UserRepository;

namespace CalorieCounterAPI.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFoodRepository Foods { get; }
        IUserRepository Users { get; }
        IUserFoodRepository UserFoods { get; }
        int Save();
    }
}