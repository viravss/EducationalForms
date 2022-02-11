using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Configuration;

namespace Infrastructure.Context;

public class EducationalFormsContext : DbContext
{
    public EducationalFormsContext(DbContextOptions options) : base(options)
    {
    }

    public Student Student { get; set; }
    public Skill Skill { get; set; }
    public Consulting Consulting { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SkillConfiguration();
        modelBuilder.StudentConfiguration();
        modelBuilder.ConsultingConfiguration();
        modelBuilder.ConsultantConfiguration();
    }
}