using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Interfaces.REST.Resources;

namespace si730pc2u202213765.API.CRM.Interfaces.REST.transform;

public class LeadResourceFromEntityAssembler
{
    public static LeadResource toResourceFromEntity(
        Lead entity)
    {
        return new LeadResource(
            entity.Id,
            entity.ActiveCampaignLeadId,
            entity.FirstName,
            entity.LastName,
            (int)entity.LeadStatus,
            entity.AssignedSalesAgentId.GetValueOrDefault(),
            entity.ContactedAt,
            entity.ApprovedAt,
            entity.ReporteddAt);
    }
}