using MediatR;
using Microsoft.AspNetCore.Authorization;
using System.API.Application;

namespace SecurityAPI.endpoint
{
    public static class ApplicationEndpoints
    {
        //public static void AddApplicationEndpoint(this WebApplication app)
        //{
        //    app.MapPost("system/v1/roles/inserir", [AllowAnonymous] async (HttpContext http, IMediator mediator, RoleRequest request) =>
        //    {
        //        return await BaseEndpoint.Ok(mediator, request);

        //    }).Produces<AuthenticateUserResponse>(StatusCodes.Status200OK)
        //.Produces(StatusCodes.Status404NotFound)
        //.Produces(StatusCodes.Status400BadRequest)
        //.Produces(StatusCodes.Status500InternalServerError);
        //}
    }
}
