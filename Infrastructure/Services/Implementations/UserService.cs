using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class UserService : CommonIdentityService<User>, IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICommonIdentityRepository<User> _repository;

    public UserService(ICommonIdentityRepository<User> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
    }

    public async Task<User?> GetUserByUserNameAndPassword(string username, string password)
    {
        return await _unitOfWork.User.GetUserByUsernameAndPassword(username, password);
    }
}