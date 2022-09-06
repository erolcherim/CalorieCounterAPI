using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.DAL;
using CalorieCounterAPI.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CalorieCounterAPI.Repositories.SessionTokenRepository
{
    public class SessionTokenRepository : GenericRepository<SessionToken>, ISessionTokenRepository
    {
        public SessionTokenRepository(ApplicationDbContext context) : base(context) { }

        public async Task<SessionToken> GetByJTI(string jti)
        {
            return await _context.SessionTokens
                .FirstOrDefaultAsync(t => t.Jti.Equals(jti));
        }
    }
}
