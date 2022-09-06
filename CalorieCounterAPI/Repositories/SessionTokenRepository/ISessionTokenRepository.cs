using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;

namespace CalorieCounterAPI.Repositories.SessionTokenRepository
{
{
    public interface ISessionTokenRepository : IGenericRepository<SessionToken>
    {
        Task<SessionToken> GetByJTI(string jti);
    }
}
}
