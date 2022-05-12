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
        services.AddStudentRepository();
        services.AddSkillRepository();
        services.AddConsultantRepository();
        services.AddConsultingRepository();

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
    public static void AddStudentRepository(this IServiceCollection services)
    {
        services.AddScoped<IStudentRepository, StudentRepository>();
    }
    public static void AddSkillRepository(this IServiceCollection services)
    {
        services.AddScoped<ISkillRepository, SkillRepository>();
    }
    public static void AddConsultantRepository(this IServiceCollection services)
    {
        services.AddScoped<IConsultantRepository, ConsultantRepository>();
    }
    public static void AddConsultingRepository(this IServiceCollection services)
    {
        services.AddScoped<IConsultingRepository, ConsultingRepository>();
    }
}