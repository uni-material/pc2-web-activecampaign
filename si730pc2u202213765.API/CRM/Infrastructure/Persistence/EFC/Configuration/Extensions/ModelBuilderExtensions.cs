using Microsoft.EntityFrameworkCore;
using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;

namespace si730pc2u202213765.API.CRM.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    
    public static void ApplyLeadConfiguration(this ModelBuilder builder)
    {
        // Lead Context
        builder.Entity<Lead>().HasKey(l => l.Id);
        builder.Entity<Lead>().Property(l => l.Id).IsRequired().ValueGeneratedOnAdd();
        
        //name and last name
        builder.Entity<Lead>().Property(l => l.FirstName).IsRequired().HasMaxLength(40);
        builder.Entity<Lead>().Property(l => l.LastName).IsRequired().HasMaxLength(40);
        
        //activeCampaignLeadId
        builder.Entity<Lead>().Property(l => l.ActiveCampaignLeadId).IsRequired();
        //status
        builder.Entity<Lead>().Property(l => l.LeadStatus).IsRequired();
        //assignedSalesAgentId
        builder.Entity<Lead>().Property(l => l.AssignedSalesAgentId).IsRequired(false);
        //contactedAt
        builder.Entity<Lead>().Property(l => l.ContactedAt).IsRequired(false);
        //approvedAt
        builder.Entity<Lead>().Property(l => l.ApprovedAt).IsRequired(false);
        //reportedAt
        builder.Entity<Lead>().Property(l => l.ReporteddAt).IsRequired(false);
    }
}

/*
 *id (int, obligatorio, autogenerado, llave primaria), 

activeCampaignLeadId(string, obligatorio, autogenerado, Guid único), 

firstName (string, obligatorio, entre 4 y 40 caracteres), 

lastName (string, obligatorio, entre 4 y 40 caracteres), 

status (int, obligatorio, restringido por ELeadStatus), 

assignedSalesAgentId (int, no obligatorio), 

contactedAt (Date, no obligatorio), 

approvedAt (Date, no obligatorio), 

reportedAt (Date, no obligatorio) .
*/