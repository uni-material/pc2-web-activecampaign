using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Domain.Model.Queries;

namespace si730pc2u202213765.API.CRM.Domain.Services;

public interface ILeadQueryService
{
    Task<IEnumerable<Lead>> Handle(GetAllLeadsQuery query);
    Task<Lead?> Handle(GetLeadByIdQuery query);
}