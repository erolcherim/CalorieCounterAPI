using CalorieCounterAPI.Repositories.FoodRepository;

namespace CalorieCounterAPI.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFoodRepository Foods { get; }

        int Save();
    }
}