namespace Presentation.Helpers;

public interface IEndpointDefinition
{
    void MapEndpoints(IEndpointRouteBuilder app);
}