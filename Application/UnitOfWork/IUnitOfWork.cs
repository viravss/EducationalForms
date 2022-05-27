using Application.Repositories;

namespace Application.UnitOfWork;

public interface IUnitOfWork : IDisposable
{

    IConsultantRepository Consultant { get; }
    IFailureReasonRepository FailureReason { get; }
    IFamiliarityMethodRepository FamiliarityMethod { get; }
    ILeadRepository Lead { get; }
    ILeadSkillRepository LeadSkill { get; }
    IServiceRepository Service { get; }
    ISkillRepository Skill { get; }
    IStudentRepository Student { get; }
    IStudentServiceRepository StudentService { get; }
    IStudentSkillRepository StudentSkill { get; }
    Task<bool> SaveChangesAsync();
}