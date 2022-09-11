using CalorieCounterAPI.DAL;
using CalorieCounterAPI.Repositories.AuthWrapperRepository;
using CalorieCounterAPI.Repositories.FoodRepository;

namespace CalorieCounterAPI.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Foods = new FoodRepository.FoodRepository(_context);
        }

        public IFoodRepository Foods
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
