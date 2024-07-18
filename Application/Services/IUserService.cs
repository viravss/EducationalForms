using Domain.Models;

namespace Application.Services;

public interface IUserService : ICommonIdentityService<User>
{
    Task<User?> GetUserByUserNameAndPassword(string username, string password);
}