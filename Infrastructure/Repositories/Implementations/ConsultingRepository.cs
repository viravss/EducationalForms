using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class ConsultingRepository : GenericRepository<Consulting>, IConsultingRepository
{
    public ConsultingRepository(EducationalFormsContext context) : base(context)
    {
    }
}