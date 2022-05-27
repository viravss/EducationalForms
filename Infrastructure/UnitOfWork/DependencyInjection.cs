using Application.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.UnitOfWork;

public static class DependencyInjection
{
    public static IServiceCollection AddUnitOfWork(this IServiceCollection service)
    {
        service.AddTransient<IUnitOfWork, UnitOfWork>();
        return service;
    }
}