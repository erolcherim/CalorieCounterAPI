using CalorieCounterAPI.Repositories.FoodRepository;
using CalorieCounterAPI.Repositories.UserRepository;

namespace CalorieCounterAPI.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFoodRepository Foods { get; }
        IUserRepository Users { get; }
        int Save();
    }
}