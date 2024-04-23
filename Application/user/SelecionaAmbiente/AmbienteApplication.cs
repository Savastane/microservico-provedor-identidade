namespace System.API.Application
{
    using FluentValidation;
    using global::Application.General.Exceptions;
    using MediatR;
    using Service.Interface;
    using Academico.Domain;    
    using Academico.Domain.Interface;

    public class AmbienteApplication : IRequestHandler<AmbienteRequest, AmbienteResponse>
    {
        private readonly IUserRepository Repository;
        private readonly ITokenService _tokenService;
        private readonly IValidator<AmbienteRequest> ValidatorRequest;

        public AmbienteApplication(IUserRepository repository, ITokenService tokenService, IValidator<AmbienteRequest> validatorRequest)
        {
            //
            Repository = repository;
            _tokenService = tokenService;
            ValidatorRequest = validatorRequest;
        }
        
        public async Task<AmbienteResponse> Handle(AmbienteRequest request, CancellationToken cancellationToken)
        {
         
            var usuario = await Repository.GetByGuidAsync(request.IdUsuario);           
                        
            var token   =  await _tokenService.GerarTokenAmbiente(usuario.Email, 
                request.IdUsuario, 
                usuario.Name, 
                request.Role,
                request.IdAplicacao, 
                request.IdOrganizacao, 
                request.Organizacao, 
                "https://localhost:5002"); 
                        
            return new AmbienteResponse().setToken(token);                         

        }
    }
}
