using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.Shared.Domain.Model.Repositories;

namespace si730pc2u202213765.API.CRM.Domain.Repositories;

public interface ILeadRepository : IBaseRepository<Lead>
{
    //• No permite que se registre dos leads con la misma combinación de firstName y lastName.
    Task<bool> ExistsByFirstNameAndLastNameAsync(string firstName, string lastName);
    
}
