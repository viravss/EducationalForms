using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;

    }
}