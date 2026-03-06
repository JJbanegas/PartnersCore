using Application.Commands.Partners.v1;
using Application.Queries.Partners.v1;
using Application.ViewModels.Partners.v1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Helpers;

namespace Presentation.Endpoints.v1;

public class PartnerEndpoints : IEndpointDefinition
{
    public void MapEndpoints(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/partner")
            .WithOpenApi()
            .WithTags("Partner")
            .WithMetadata(new Microsoft.AspNetCore.Mvc.ApiExplorerSettingsAttribute {GroupName = "v1"})
            .WithGroupName("v1");
        
        group.MapGet("/GetAllPartners",
            async ([FromServices] IMediator mediator) => await mediator.Send(new PartnerGetAllQuery()));

        group.MapPost("/CreatePartner",
            async ([FromServices] IMediator mediator, [FromBody] PartnerCreateRequestViewModel model) =>
            await mediator.Send(new PartnerCreateCommand(model)));
    }
}