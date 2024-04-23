using Application.General.Exceptions;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using System.API.Application;



namespace SecurityAPI.endpoint
{


    public static class BaseEndpoint
    {



        public static async Task<IResult> Ok<TResponse>(IMediator mediator, IRequest<TResponse> request, string created = null )
        {
            try
            {
                if (created is null)
                {
                    // get 
                    // sucesso na requisicao
                    return Results.Ok(await mediator.Send(request));
                }
                else
                {
                    // post 
                    // recurso criado
                    return Results.Created(created, await mediator.Send(request));
                    

                }

                


            }
            catch (ConflitException ex)
            {
                var mensagem = new Dictionary<string, string[]>();
                mensagem.Add("Conflit", new string[1] { ex.Message });

                return Results.Conflict(mensagem);
            }
            catch (NotFoundException ex)
            {
                var mensagem = new Dictionary<string, string[]>();
                mensagem.Add("NotFound", new string[1] { ex.Message });

                return Results.NotFound(mensagem);
            }
            catch (UnauthorizedException ex)
            {
                return Results.Unauthorized();
            }
            catch (BadRequestException ex)
            {
                if (ex.GetDicionario() is null)
                {

                    var mensagem = new Dictionary<string, string[]>();
                    mensagem.Add("BadRequest", new string[1] { ex.Message });

                    return Results.BadRequest(mensagem);
                }
                else
                {
                    return Results.BadRequest(ex.GetDicionario());
                }

            }
            catch (Exception ex)
            {
                return Results.StatusCode(StatusCodes.Status500InternalServerError);
            }

            return null;
        }

        public static async Task<IResult> NoContent<TResponse>(IMediator mediator, IRequest<TResponse> request)
        {

            try
            {
                //requisicao aceita para processamento
                var response = await mediator.Send(request);

                return Results.Created("",response);
            }
            catch (NotFoundException ex)
            {

                var mensagem = new Dictionary<string, string[]>();
                mensagem.Add("NotFound", new string[1] { ex.Message });

                return Results.NotFound(mensagem);
            }
            catch (BadRequestException ex)
            {
                if (ex.GetDicionario() is null)
                {

                    var mensagem = new Dictionary<string, string[]>();
                    mensagem.Add("BadRequest", new string[1] { ex.Message });

                    return Results.BadRequest(mensagem);
                }
                else
                {
                    return Results.BadRequest(ex.GetDicionario());
                }

            }
            catch (Exception ex)
            {
                return Results.StatusCode(StatusCodes.Status500InternalServerError);
            }

            return null;

        }

        public static async Task<IResult> Accepted<TResponse>(IMediator mediator, IRequest<TResponse> request)
        {

            try
            {
                //requisicao aceita para processamento
                var response = await mediator.Send(request);

                return Results.Accepted();
            }
            catch (NotFoundException ex)
            {

                var mensagem = new Dictionary<string, string[]>();
                mensagem.Add("NotFound", new string[1] { ex.Message });

                return Results.NotFound(mensagem);
            }
            catch (BadRequestException ex)
            {
                if (ex.GetDicionario() is null)
                {

                    var mensagem = new Dictionary<string, string[]>();
                    mensagem.Add("BadRequest", new string[1] { ex.Message });

                    return Results.BadRequest(mensagem);
                }
                else
                {
                    return Results.BadRequest(ex.GetDicionario());
                }

            }
            catch (Exception ex)
            {
                return Results.StatusCode(StatusCodes.Status500InternalServerError);
            }

            return null;

        }
    }
}
