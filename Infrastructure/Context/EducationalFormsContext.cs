using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class EducationalFormsContext : DbContext
{
    public EducationalFormsContext(DbContextOptions options) : base(options)
    {
    }

    public Student Students { get; set; }
    public Skill Skills { get; set; }
    public Consulting Consultings { get; set; }

}