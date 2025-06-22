using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Domain.Model.Commands;

namespace si730pc2u202213765.API.CRM.Domain.Services;

public interface ILeadCommandService
{
    Task<Lead?> Handle(CreateLeadCommand command);
}