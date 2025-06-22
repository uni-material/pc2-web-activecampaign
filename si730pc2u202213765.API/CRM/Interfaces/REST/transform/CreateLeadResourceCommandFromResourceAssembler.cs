using si730pc2u202213765.API.CRM.Domain.Model.Commands;
using si730pc2u202213765.API.CRM.Interfaces.REST.Resources;

namespace si730pc2u202213765.API.CRM.Interfaces.REST.transform;

public class CreateLeadResourceCommandFromResourceAssembler
{
    public static CreateLeadCommand toCommandFromResource(CreateLeadResource resource)
    {
        return new CreateLeadCommand(
            resource.FirstName,
            resource.LastName,
            (int)resource.LeadStatus!,
            resource.AssignedSalesAgentId,
            resource.ContactedAt,
            resource.ApprovedAt,
            resource.ReportedAt);
    }
}
