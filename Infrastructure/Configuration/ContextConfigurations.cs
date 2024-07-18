using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Configuration;

public static class ContextConfigurations
{
    public static void ConsultantConfiguration(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Student>(entity =>
        //    entity.HasOne(sc => sc.)
        //        .WithMany(s => s.PackageItems)
        //        .HasForeignKey(m => m.PackageId)
        //        .HasConstraintName("FK_Package_PackageItem"));

        modelBuilder.Entity<Consultant>()
            .Property(p => p.IsActive)
            .HasDefaultValue(true);
    }

    public static void FailureReasonConfiguration(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Student>(entity =>
        //    entity.HasOne(sc => sc.)
        //        .WithMany(s => s.PackageItems)
        //        .HasForeignKey(m => m.PackageId)
        //        .HasConstraintName("FK_Package_PackageItem"));

        modelBuilder.Entity<FailureReason>()
            .Property(p => p.IsActive)
            .HasDefaultValue(true);
    }

    public static void FamiliarityMethodConfiguration(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Student>(entity =>
        //    entity.HasOne(sc => sc.)
        //        .WithMany(s => s.PackageItems)
        //        .HasForeignKey(m => m.PackageId)
        //        .HasConstraintName("FK_Package_PackageItem"));

        modelBuilder.Entity<FamiliarityMethod>()
            .Property(p => p.IsActive)
            .HasDefaultValue(true);
    }

    public static void LeadConfiguration(this ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Lead>(entity =>
        //    entity.HasOne(sc => sc.)
        //        .WithMany(s => s.PackageItems)
        //        .HasForeignKey(m => m.PackageId)
        //        .HasConstraintName("FK_Package_PackageItem"));

        //modelBuilder.Entity<FailureReason>()
        //    .Property(p => p.IsActive)
        //    .HasDefaultValue(true);
    }

    public static void LeadSkillConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LeadSkill>(entity =>
            entity.HasOne(sc => sc.Lead)
                .WithMany(s => s.LeadSkills)
                .HasForeignKey(m => m.LeadId)
                .HasConstraintName("FK_Lead_LeadSkills"));

        //modelBuilder.Entity<FailureReason>()
        //    .Property(p => p.IsActive)
        //    .HasDefaultValue(true);
    }

    public static void ServiceConfiguration(this ModelBuilder modelBuilder)
    {
    }

    public static void SKillConfiguration(this ModelBuilder modelBuilder)
    {
    }

    public static void StudentConfiguration(this ModelBuilder modelBuilder)
    {
    }

    public static void StudentServiceConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentService>(entity =>
            entity.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentServices)
                .HasForeignKey(m => m.StudentId)
                .HasConstraintName("FK_Student_StudentServices"));
    }

    public static void StudentSkillConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentSkill>(entity =>
            entity.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentSkills)
                .HasForeignKey(m => m.StudentId)
                .HasConstraintName("FK_Student_StudentSkills"));
    }

    public static void UserConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
            entity.HasOne(t => t.Consultant)
                .WithOne(r => r.User)
                .HasConstraintName("FK_User_Consultant"));
    }
}