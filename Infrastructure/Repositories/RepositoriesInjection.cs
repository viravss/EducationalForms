using Application.Repositories;
using Domain.Models;
using Infrastructure.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repositories;

public static class RepositoriesInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddIdentityBaseRepository();
        services.AddBaseRepository();
        services.AddConsultant();
        services.AddFailureReason();
        services.AddFamiliarityMethod();
        services.AddLead();
        services.AddLeadSkill();
        services.AddService();
        services.AddSkill();
        services.AddStudent();
        services.AddStudentService();
        services.AddStudentSkill();
        services.AddUser();
        return services;
    }

    private static void AddIdentityBaseRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICommonIdentityRepository<>), typeof(CommonIdentityRepository<>));
    }

    private static void AddBaseRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));
    }

    private static void AddConsultant(this IServiceCollection service)
    {
        service.AddScoped<IConsultantRepository, ConsultantRepository>();
    }

    private static void AddFailureReason(this IServiceCollection service)
    {
        service.AddScoped<IFailureReasonRepository, FailureReasonRepository>();
    }

    private static void AddFamiliarityMethod(this IServiceCollection service)
    {
        service.AddScoped<IFamiliarityMethodRepository, FamiliarityMethodRepository>();
    }

    private static void AddLead(this IServiceCollection service)
    {
        service.AddScoped<ILeadRepository, LeadRepository>();
    }

    private static void AddLeadSkill(this IServiceCollection service)
    {
        service.AddScoped<ILeadSkillRepository, LeadSkillRepository>();
    }

    private static void AddService(this IServiceCollection service)
    {
        service.AddScoped<IServiceRepository, ServiceRepository>();
    }

    private static void AddSkill(this IServiceCollection service)
    {
        service.AddScoped<ISkillRepository, SkillRepository>();
    }

    private static void AddStudent(this IServiceCollection service)
    {
        service.AddScoped<IStudentRepository, StudentRepository>();
    }

    private static void AddStudentService(this IServiceCollection service)
    {
        service.AddScoped<IStudentServiceRepository, StudentServiceRepository>();
    }

    private static void AddStudentSkill(this IServiceCollection service)
    {
        service.AddScoped<IStudentSkillRepository, StudentSkillRepository>();
    }

    public static void AddUser(this IServiceCollection service)
    {
        service.AddScoped<IUserRepository, UserRepository>();
    }
}