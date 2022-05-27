using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class FailureReasonService : CommonIdentityService<FailureReason>, IFailureReasonService
{
    private readonly IUnitOfWork _unitOfWork;
    public FailureReasonService(ICommonIdentityRepository<FailureReason> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}