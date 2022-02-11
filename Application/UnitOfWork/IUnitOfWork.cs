using Application.Repositories;

namespace Application.UnitOfWork;

public interface IUnitOfWork : IDisposable
{

    public IStudentRepository Student { get; }
    public IConsultantRepository Consultant { get; }
    public IConsultingRepository Consulting { get; }
    public ISkillRepository Skill { get; }
    Task<bool> SaveChangesAsync();
}