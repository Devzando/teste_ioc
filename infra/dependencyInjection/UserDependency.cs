using application.repositories;
using application.usecases;
using infra.database.entityFramework.repositories;
using Microsoft.Extensions.DependencyInjection;

namespace infra.DependencyInjection;

public static class UserDependency
{
    public static void AddUserDependency(IServiceCollection services)
    {
        services.AddScoped<CreateUser>();
        services.AddScoped<ListUser>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}