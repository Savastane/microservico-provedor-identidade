using MediatR;
using Microsoft.AspNetCore.Authorization;
using System.API.Application;

namespace SecurityAPI.endpoint
{
    public static class OrganizationEndpoints
    {
        //public static void AddOrganizationEndpoint(this WebApplication app)
        //{
        //    app.MapPost("Organization/v1/inserir", [AllowAnonymous] async (HttpContext http, IMediator mediator, RoleRequest request) =>
        //    {
        //        return await BaseEndpoint.Ok(mediator, request);

        //    }).Produces<AuthenticateUserResponse>(StatusCodes.Status200OK)
        //.Produces(StatusCodes.Status404NotFound)
        //.Produces(StatusCodes.Status400BadRequest)
        //.Produces(StatusCodes.Status500InternalServerError);
        //}
    }
}
