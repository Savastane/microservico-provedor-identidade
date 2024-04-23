using MediatR;
using Microsoft.AspNetCore.Authorization;
using System.API.Application;

namespace SecurityAPI.endpoint
{
    public static class PlatformEndpoints    
    {        
        public static void AddPlataformEndpoint(this WebApplication app)
        {
            app.MapPost("platform/v1/inserir", [AllowAnonymous] async (HttpContext http, IMediator mediator, RoleRequest request) =>
            {
                return await BaseEndpoint.Accepted(mediator, request);

            }).Produces<AuthenticateUserResponse>(StatusCodes.Status202Accepted)
        .Produces(StatusCodes.Status409Conflict)
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status500InternalServerError);
        }

    }
}
