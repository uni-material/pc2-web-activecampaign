using Microsoft.EntityFrameworkCore;
using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Domain.Repositories;
using si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using si730pc2u202213765.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace si730pc2u202213765.API.CRM.Infrastructure.Persistence.EFC.Configuration.Repositories;

public class LeadRepository(AppDbContext context): BaseRepository<Lead>(context), ILeadRepository
{
    public async Task<bool> ExistsByFirstNameAndLastNameAsync(string firstName, string lastName)
    {
        return await Context.Set<Lead>().AnyAsync(lead => lead.FirstName == firstName && lead.LastName == lastName);
    }

    
}