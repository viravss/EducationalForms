using Domain.Models;

namespace Application.Repositories;

public interface IUserRepository : ICommonIdentityRepository<User>
{
    Task<User?> GetUserByUsernameAndPassword(string username, string password);
}