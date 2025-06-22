using si730pc2u202213765.API.CRM.Domain.Model.ValueObjects;

namespace si730pc2u202213765.API.CRM.Domain.Model.Commands;

public record CreateLeadCommand(
    string FirstName, 
    string LastName,
    int? Status,
    int? AssignedSalesAgentId,
    DateTime? ContactedAt,
    DateTime? ApprovedAt,
    DateTime? ReportedAt
    );