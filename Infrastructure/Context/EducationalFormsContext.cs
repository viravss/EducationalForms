using Domain.Models;
using Domain.Models.BaseModel;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Configuration;

namespace Infrastructure.Context;

public class EducationalFormsContext : DbContext
{
    public EducationalFormsContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Student { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<Consultant> Consultant { get; set; }
    public DbSet<FailureReason> FailureReason { get; set; }
    public DbSet<FamiliarityMethod> FamiliarityMethod { get; set; }
    public DbSet<Lead> Lead { get; set; }
    public DbSet<LeadSkill> LeadSkill { get; set; }
    public DbSet<Service> Service { get; set; }
    public DbSet<StudentService> StudentService { get; set; }
    public DbSet<StudentSkill> StudentSkill { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConsultantConfiguration();
        modelBuilder.StudentConfiguration();
        modelBuilder.FailureReasonConfiguration();
        modelBuilder.FamiliarityMethodConfiguration();
        modelBuilder.LeadConfiguration();
        modelBuilder.SKillConfiguration();
        modelBuilder.LeadSkillConfiguration();
        modelBuilder.ServiceConfiguration();
        modelBuilder.StudentServiceConfiguration();
        modelBuilder.StudentSkillConfiguration();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entityEntry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entityEntry.State)
            {

                case EntityState.Modified:
                    entityEntry.Entity.ModifyOn = DateTime.Now;
                    break;
                case EntityState.Added:
                    entityEntry.Entity.CreateOn = DateTime.Now;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}