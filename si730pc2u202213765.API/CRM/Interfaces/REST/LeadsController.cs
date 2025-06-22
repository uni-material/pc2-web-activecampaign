using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using si730pc2u202213765.API.CRM.Domain.Model.Queries;
using si730pc2u202213765.API.CRM.Domain.Services;
using si730pc2u202213765.API.CRM.Interfaces.REST.Resources;
using si730pc2u202213765.API.CRM.Interfaces.REST.transform;
using Swashbuckle.AspNetCore.Annotations;

namespace si730pc2u202213765.API.CRM.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Lead Endpoints")]
public class LeadsController(ILeadCommandService leadCommandService, ILeadQueryService leadQueryService)
    : ControllerBase
{

    [HttpGet("{leadId:int}")]
    [SwaggerResponse(StatusCodes.Status200OK, "Lead found", typeof(LeadResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Lead not found")]
    public async Task<IActionResult> GetLeadById([FromRoute] int leadId)
    {
        {
            var getLeadByIdQuery = new GetLeadByIdQuery(leadId);
            var lead = await leadQueryService.Handle(getLeadByIdQuery);
            if (lead is null) return NotFound();
            var leadResource = LeadResourceFromEntityAssembler.toResourceFromEntity(lead);
            return Ok(leadResource);
        }
    }
    
[HttpPost]
    [SwaggerOperation(
        Summary = "Creates a new lead",
        Description = "Creates a new lead with the provided details.",
        OperationId = "CreateLead")]
    [SwaggerResponse(StatusCodes.Status201Created, "Lead created successfully")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid lead data")]
    public async Task<IActionResult> CreateLead([FromBody] CreateLeadResource resource)
    {
        var createLeadCommand = CreateLeadResourceCommandFromResourceAssembler.toCommandFromResource(resource);
        
        var lead = await leadCommandService.Handle(createLeadCommand);
        if (lead is null) return BadRequest("Lead could not be created.");
        var leadResource = LeadResourceFromEntityAssembler.toResourceFromEntity(lead);
        return CreatedAtAction(nameof(GetLeadById), new { leadId = lead.Id }, leadResource);
    }
}