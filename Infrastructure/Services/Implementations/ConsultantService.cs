using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class ConsultantService : CommonService<Consultant>, IConsultantService
{
    private readonly IUnitOfWork _unitOfWork;
    public ConsultantService(ICommonRepository<Consultant> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}