using Evently.Modules.Events.Api.Database;
using Evently.Modules.Events.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Evently.API.Extensions;

internal static class MigrationExtensions
{
    internal static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        ApplyMigrations<EventsDbContext>(scope);
    }

    private static void ApplyMigrations<TBContext>(IServiceScope scope)
        where TBContext : DbContext
    {
        using TBContext context = scope.ServiceProvider.GetRequiredService<TBContext>();

        context.Database.Migrate();
    }
}
