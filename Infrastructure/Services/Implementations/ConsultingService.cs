using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Domain.Models;

namespace Infrastructure.Services.Implementations;

public class ConsultingService : GenericService<Consulting>, IConsultingService
{
    private readonly IUnitOfWork _unitOfWork;
    public ConsultingService(IGenericRepository<Consulting> repository, IUnitOfWork unitOfWork) : base(repository)
    {
        _unitOfWork = unitOfWork;
    }
}