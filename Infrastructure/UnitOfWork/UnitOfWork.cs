using Application.Repositories;
using Application.UnitOfWork;
using Infrastructure.Context;
using Infrastructure.Repositories.Implementations;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly EducationalFormsContext _context;
    public UnitOfWork(EducationalFormsContext context)
    {
        _context = context;
        Consultant = new ConsultantRepository(_context);
        FailureReason = new FailureReasonRepository(_context);
        FamiliarityMethod = new FamiliarityMethodRepository(_context);
        Lead = new LeadRepository(_context);
        LeadSkill = new LeadSkillRepository(_context);
        Service = new ServiceRepository(_context);
        Skill = new SkillRepository(_context);
        Student = new StudentRepository(_context);
        StudentService = new StudentServiceRepository(_context);
        StudentSkill = new StudentSkillRepository(_context);
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    public IConsultantRepository Consultant { get; }
    public IFailureReasonRepository FailureReason { get; }
    public IFamiliarityMethodRepository FamiliarityMethod { get; }
    public ILeadRepository Lead { get; }
    public ILeadSkillRepository LeadSkill { get; }
    public IServiceRepository Service { get; }
    public ISkillRepository Skill { get; }
    public IStudentRepository Student { get; }
    public IStudentServiceRepository StudentService { get; }
    public IStudentSkillRepository StudentSkill { get; }

    public async Task<bool> SaveChangesAsync()
    {
        await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.SaveChangesAsync();
            await _context.Database.CommitTransactionAsync();
            return true;
        }
        catch (Exception e)
        {
            //TODO Log 
            await _context.Database.RollbackTransactionAsync();
            return false;
        }
    }
}