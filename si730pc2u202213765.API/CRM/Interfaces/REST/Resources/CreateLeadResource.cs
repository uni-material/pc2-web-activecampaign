namespace si730pc2u202213765.API.CRM.Interfaces.REST.Resources;

public record CreateLeadResource(
    string FirstName, 
    string LastName,
    int? LeadStatus,
    int AssignedSalesAgentId,
    DateTime? ContactedAt,
    DateTime? ApprovedAt,
    DateTime? ReportedAt
    );