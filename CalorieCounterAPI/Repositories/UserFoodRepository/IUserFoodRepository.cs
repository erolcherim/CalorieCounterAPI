using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;

namespace CalorieCounterAPI.Repositories.UserFoodRepository
{
    public interface IUserFoodRepository: IGenericRepository<UserFood>
    {
        Task<List<UserFood>> GetAll();
        Task<List<UserFood>> GetAllByUserId(int id);
    }
}