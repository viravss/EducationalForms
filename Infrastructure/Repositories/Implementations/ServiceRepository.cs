using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class ServiceRepository : CommonIdentityRepository<Service>, IServiceRepository
{
    public ServiceRepository(EducationalFormsContext context) : base(context)
    {
    }
}