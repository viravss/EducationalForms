using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class FamiliarityMethodService : CommonIdentityService<FamiliarityMethod>, IFamiliarityMethodService
{
    private readonly IUnitOfWork _unitOfWork;
    public FamiliarityMethodService(ICommonIdentityRepository<FamiliarityMethod> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}