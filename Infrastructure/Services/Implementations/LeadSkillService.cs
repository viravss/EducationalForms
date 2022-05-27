using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class ServiceService : CommonIdentityService<Service>, IServiceService
{
    private readonly IUnitOfWork _unitOfWork;
    public ServiceService(ICommonIdentityRepository<Service> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}