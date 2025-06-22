using si730pc2u202213765.API.Shared.Domain.Model.Repositories;
using si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}