using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration;

public static class ContextConfigurations
{
    public static void StudentConfiguration(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Student>(entity =>
        //    entity.HasOne(sc => sc.)
        //        .WithMany(s => s.PackageItems)
        //        .HasForeignKey(m => m.PackageId)
        //        .HasConstraintName("FK_Package_PackageItem"));

        //modelBuilder.Entity<PackageItem>()
        //    .Property(p => p.IsActive)
        //    .HasDefaultValue(true);
    }
    public static void SkillConfiguration(this ModelBuilder modelBuilder)
    {

    }
    public static void ConsultantConfiguration(this ModelBuilder modelBuilder)
    {

    }
    public static void ConsultingConfiguration(this ModelBuilder modelBuilder)
    {

    }
}