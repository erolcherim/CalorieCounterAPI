using CalorieCounterAPI.DAL;
using CalorieCounterAPI.Repositories.AuthWrapperRepository;
using CalorieCounterAPI.Repositories.FoodRepository;
using CalorieCounterAPI.Repositories.UserFoodRepository;
using CalorieCounterAPI.Repositories.UserRepository;

namespace CalorieCounterAPI.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Foods = new FoodRepository.FoodRepository(_context);
            UserFoods = new UserFoodRepository.UserFoodRepository(_context);
        }

        public IFoodRepository Foods
        {
            get;
            private set;
        }

        public IUserRepository Users
        {
            get;
            private set;
        }

        public IUserFoodRepository UserFoods
        {
            get;
            private set;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
        
    }
}
