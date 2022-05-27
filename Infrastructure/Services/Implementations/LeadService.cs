using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class LeadService : CommonIdentityService<Lead>, ILeadService
{
    private readonly IUnitOfWork _unitOfWork;
    public LeadService(ICommonIdentityRepository<Lead> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}