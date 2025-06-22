using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Domain.Model.Queries;
using si730pc2u202213765.API.CRM.Domain.Repositories;
using si730pc2u202213765.API.CRM.Domain.Services;

namespace si730pc2u202213765.API.CRM.Application.Internal.QueryServices;

public class LeadQueryService(ILeadRepository leadRepository): ILeadQueryService
{
    public async Task<IEnumerable<Lead>> Handle(GetAllLeadsQuery query)
    {
        return await leadRepository.ListAsync();
    }

    public async Task<Lead?> Handle(GetLeadByIdQuery query)
    {
        return await leadRepository.FindByIdAsync(query.LeadId);
    }
}