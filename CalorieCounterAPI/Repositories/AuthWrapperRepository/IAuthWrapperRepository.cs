using CalorieCounterAPI.Repositories.SessionTokenRepository;
using CalorieCounterAPI.Repositories.UserRepository;

namespace CalorieCounterAPI.Repositories.AuthWrapperRepository
{
    public interface IAuthWrapperRepository
    {
        ISessionTokenRepository SessionToken { get; }
        IUserRepository User { get; }
        Task SaveAsync();
    }
}
