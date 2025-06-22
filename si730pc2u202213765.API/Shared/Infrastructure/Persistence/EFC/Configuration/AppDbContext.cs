using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions.Extensions;

using si730pc2u202213765.API.CRM.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Add the created and updated interceptor
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyLeadConfiguration();

        builder.UseSnakeCaseNamingConvention();
    }
}