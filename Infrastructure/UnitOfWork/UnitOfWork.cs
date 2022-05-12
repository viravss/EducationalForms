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
        Student = new StudentRepository(_context);
        Consultant = new ConsultantRepository(_context);
        Consulting = new ConsultingRepository(_context);
        Skill = new SkillRepository(_context);
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IStudentRepository Student { get; }
    public IConsultantRepository Consultant { get; }
    public IConsultingRepository Consulting { get; }
    public ISkillRepository Skill { get; }
    public async Task<bool> SaveChangesAsync()
    {
        await _context.Database.BeginTransactionAsync();
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            //TODO Log 
            await _context.Database.CommitTransactionAsync();
            return false;
        }
    }
}