using MediatR;
using Microsoft.AspNetCore.Authorization;
using System.API.Application;



namespace SecurityAPI.endpoint
{


    public static class UserEndpoints
    {

        

        public static void AddUserEndpoint(this WebApplication app)
        {
            
            
            app.MapPost("user/v1/autenticar", [AllowAnonymous] async (HttpContext http, IMediator mediator, AuthenticateUserRequest request) =>
            {
                return await BaseEndpoint.Ok(mediator, request);

            }).Produces<AuthenticateUserResponse>(StatusCodes.Status200OK)
              .Produces(StatusCodes.Status404NotFound)
              .Produces(StatusCodes.Status400BadRequest)
              .Produces(StatusCodes.Status500InternalServerError);

            app.MapPost("user/v1/autenticar/ambiente", [AllowAnonymous] async (HttpContext http, IMediator mediator,  AmbienteRequest request) =>
            {
                return await BaseEndpoint.Ok(mediator, request);

            }).Produces<AuthenticateUserResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status500InternalServerError);

            app.MapPost("user/v1/insert", [AllowAnonymous] async (HttpContext http, IMediator mediator, InsertUserRequest request) =>
            {
                return await BaseEndpoint.Ok(mediator, request);

            }).Produces<InsertUserResponse>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status202Accepted)
                .Produces(StatusCodes.Status400BadRequest)
                .Produces(StatusCodes.Status500InternalServerError);

            app.MapPut("user/v1/update/{id:guid}", [AllowAnonymous] async (HttpContext http, IMediator mediator, InsertUserRequest request, Guid id) =>
            {
                return await BaseEndpoint.Ok(mediator, request);

            }).Produces<InsertUserResponse>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .Produces(StatusCodes.Status500InternalServerError);




        }


       
    }
}
