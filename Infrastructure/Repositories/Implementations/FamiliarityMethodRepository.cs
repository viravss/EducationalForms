using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class FamiliarityMethodRepository : CommonIdentityRepository<FamiliarityMethod>, IFamiliarityMethodRepository
{
    public FamiliarityMethodRepository(EducationalFormsContext context) : base(context)
    {
    }
}