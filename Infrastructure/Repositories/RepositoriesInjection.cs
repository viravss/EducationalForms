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
        return services;
    }
    public static void AddIdentityBaseRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICommonIdentityRepository<>), typeof(CommonIdentityRepository<>));
    }
    public static void AddBaseRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));
    }
    public static void AddConsultant(this IServiceCollection service)
    {
        service.AddScoped<IConsultantRepository, ConsultantRepository>();
    }
    public static void AddFailureReason(this IServiceCollection service)
    {
        service.AddScoped<IFailureReasonRepository, FailureReasonRepository>();
    }
    public static void AddFamiliarityMethod(this IServiceCollection service)
    {
        service.AddScoped<IFamiliarityMethodRepository, FamiliarityMethodRepository>();
    }
    public static void AddLead(this IServiceCollection service)
    {
        service.AddScoped<ILeadRepository, LeadRepository>();
    }
    public static void AddLeadSkill(this IServiceCollection service)
    {
        service.AddScoped<ILeadSkillRepository, LeadSkillRepository>();
    }
    public static void AddService(this IServiceCollection service)
    {
        service.AddScoped<IServiceRepository, ServiceRepository>();
    }
    public static void AddSkill(this IServiceCollection service)
    {
        service.AddScoped<ISkillRepository, SkillRepository>();
    }
    public static void AddStudent(this IServiceCollection service)
    {
        service.AddScoped<IStudentRepository, StudentRepository>();
    }
    public static void AddStudentService(this IServiceCollection service)
    {
        service.AddScoped<IStudentServiceRepository, StudentServiceRepository>();
    }
    public static void AddStudentSkill(this IServiceCollection service)
    {
        service.AddScoped<IStudentSkillRepository, StudentSkillRepository>();
    }


}