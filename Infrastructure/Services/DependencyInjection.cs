using System.ComponentModel.Design;
using Application.Services;
using Infrastructure.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection service)
    {
        service.AddConsultant();
        service.AddFailureReason();
        service.AddFamiliarityMethod();
        service.AddLead();
        service.AddLeadSkill();
        service.AddService();
        service.AddSkill();
        service.AddStudent();
        service.AddStudentService();
        service.AddStudentSkill();
        service.AddUser();
        return service;
    }

    private static void AddConsultant(this IServiceCollection service)
    {
        service.AddScoped<IConsultantService, ConsultantService>();
    }

    private static void AddFailureReason(this IServiceCollection service)
    {
        service.AddScoped<IFailureReasonService, FailureReasonService>();
    }

    private static void AddFamiliarityMethod(this IServiceCollection service)
    {
        service.AddScoped<IFamiliarityMethodService, FamiliarityMethodService>();
    }

    private static void AddLead(this IServiceCollection service)
    {
        service.AddScoped<ILeadService, LeadService>();
    }

    private static void AddLeadSkill(this IServiceCollection service)
    {
        service.AddScoped<ILeadSkillService, LeadSkillService>();
    }

    private static void AddService(this IServiceCollection service)
    {
        service.AddScoped<IServiceService, ServiceService>();
    }

    private static void AddSkill(this IServiceCollection service)
    {
        service.AddScoped<ISkillService, SkillService>();
    }

    private static void AddStudent(this IServiceCollection service)
    {
        service.AddScoped<IStudentService, StudentService>();
    }

    private static void AddStudentService(this IServiceCollection service)
    {
        service.AddScoped<IStudentService, StudentService>();
    }

    private static void AddStudentSkill(this IServiceCollection service)
    {
        service.AddScoped<IStudentSkillService, StudentSkillService>();
    }

    private static void AddUser(this IServiceCollection service)
    {
        service.AddScoped<IUserService, UserService>();
    }
}