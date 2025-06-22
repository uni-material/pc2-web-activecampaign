using si730pc2u202213765.API.CRM.Domain.Model.Commands;
using si730pc2u202213765.API.CRM.Domain.Model.ValueObjects;

namespace si730pc2u202213765.API.CRM.Domain.Model.Aggregates;

public partial class Lead
{
    public int Id { get; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Guid ActiveCampaignLeadId { get; private set; } = Guid.NewGuid();
    public int? AssignedSalesAgentId { get; private set; }
    public ELeadStatus LeadStatus { get; protected set; }
    public DateTime? ContactedAt { get; private set; }
    public DateTime? ApprovedAt { get; private set; }
    public DateTime? ReporteddAt { get; private set; }

    public Lead(string firstName, string lastName, int assignedSalesAgentId)
    {
        FirstName = firstName;
        LastName = lastName;
        AssignedSalesAgentId = assignedSalesAgentId;
        LeadStatus = ELeadStatus.Open;
        ContactedAt = null;
        ApprovedAt = null;
        ReporteddAt = null;
    }

    public Lead()
    {
        
    }

    public void Contacted()
    {
        LeadStatus = ELeadStatus.Contacted;
    }
    
    public void MeetingSet()
    {
        LeadStatus = ELeadStatus.MeetingSet;
    }

    public void Qualified()
    {
        LeadStatus = ELeadStatus.Qualified;
    }
    
    public void Customer()
    {
        LeadStatus = ELeadStatus.Customer;
    }
    
    public void OpportunityLost()
    {
        LeadStatus = ELeadStatus.OpportunityLost;
    }
    
    public void Unqualified()
    {
        LeadStatus = ELeadStatus.Unqualified;
    }
    
    public void InnactiveCustomer()
    {
        LeadStatus = ELeadStatus.InnactiveCustomer;
    }

    public Lead(CreateLeadCommand command)
    {
        FirstName = command.FirstName;
        LastName = command.LastName;
        AssignedSalesAgentId = command.AssignedSalesAgentId;
        LeadStatus = command.Status.HasValue ? (ELeadStatus)command.Status : ELeadStatus.Open;
        ContactedAt = command.ContactedAt;
        ApprovedAt = command.ApprovedAt;
        ReporteddAt = command.ReportedAt;
    } 
    
    
}