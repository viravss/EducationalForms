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
        return service;
    }

    public static void AddConsultant(this IServiceCollection service)
    {
        service.AddScoped<IConsultantService, ConsultantService>();
    }
    public static void AddFailureReason(this IServiceCollection service)
    {
        service.AddScoped<IFailureReasonService, FailureReasonService>();
    }
    public static void AddFamiliarityMethod(this IServiceCollection service)
    {
        service.AddScoped<IFamiliarityMethodService, FamiliarityMethodService>();
    }
    public static void AddLead(this IServiceCollection service)
    {
        service.AddScoped<ILeadService, LeadService>();
    }
    public static void AddLeadSkill(this IServiceCollection service)
    {
        service.AddScoped<ILeadSkillService, LeadSkillService>();
    }
    public static void AddService(this IServiceCollection service)
    {
        service.AddScoped<IServiceService, ServiceService>();
    }
    public static void AddSkill(this IServiceCollection service)
    {
        service.AddScoped<ISkillService, SkillService>();
    }
    public static void AddStudent(this IServiceCollection service)
    {
        service.AddScoped<IStudentService, StudentService>();
    }
    public static void AddStudentService(this IServiceCollection service)
    {
        service.AddScoped<IStudentService, StudentService>();
    }
    public static void AddStudentSkill(this IServiceCollection service)
    {
        service.AddScoped<IStudentSkillService, StudentSkillService>();
    }

}