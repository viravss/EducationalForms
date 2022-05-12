using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class ConsultingService : CommonService<Consulting>, IConsultingService
{
    private readonly IUnitOfWork _unitOfWork;
    public ConsultingService(ICommonRepository<Consulting> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}