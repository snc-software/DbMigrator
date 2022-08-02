using DbMigrator.Core;
using DbMigrator.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DbMigrator.PostgreSQL.DI;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbMigrator(this IServiceCollection services)
    {
        services.AddSingleton<IMigrator, Migrator>();
        return services;
    }
}