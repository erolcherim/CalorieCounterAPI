using CalorieCounterAPI.DAL;
using CalorieCounterAPI.Repositories.AuthWrapperRepository;
using CalorieCounterAPI.Repositories.SessionTokenRepository;
using CalorieCounterAPI.Repositories.UserRepository;

namespace CalorieCounterAPI.Repositories.AuthRepositoryWrapper
{
    public class AuthWrapperRepository : IAuthWrapperRepository
    {
        private readonly ApplicationDbContext _context;
        private IUserRepository _user;
        private ISessionTokenRepository _sessionToken;

        public AuthWrapperRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository.UserRepository(_context); //Double check
                return _user;
            }
        }

        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository.SessionTokenRepository(_context);
                return _sessionToken;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
