using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Repositories.Implementations;

public class FailureReasonRepository : CommonIdentityRepository<FailureReason>, IFailureReasonRepository
{
    public FailureReasonRepository(EducationalFormsContext context) : base(context)
    {
    }
}