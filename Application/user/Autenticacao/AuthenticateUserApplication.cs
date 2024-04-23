namespace System.API.Application
{
    using FluentValidation;
    using global::Application.General.Exceptions;
    using MediatR;
    using Service.Interface;       
    using Academico.Domain.Interface;
    using system.Security.API.Domain.Abstracts;
    using system.Security.API.Repository;

    public class AuthenticateUserApplication : IRequestHandler<AuthenticateUserRequest, AuthenticateUserResponse>
    {
        private readonly IUnitOfWork _UnitOfWork;        
        private readonly ITokenService _tokenService;
        private readonly IValidator<AuthenticateUserRequest> ValidatorRequest;

        public AuthenticateUserApplication(IUnitOfWork UnitOfWork, ITokenService tokenService, IValidator<AuthenticateUserRequest> validatorRequest)
        {

            _UnitOfWork = UnitOfWork;            
            _tokenService = tokenService;            
            ValidatorRequest = validatorRequest;
        }
        
        public async Task<AuthenticateUserResponse> Handle(AuthenticateUserRequest request, CancellationToken cancellationToken)
        {
            var usuario = await _UnitOfWork.GetUserRepository().Autenticar(request.Mapear());
                          
                        
            if (usuario is null)            
                throw new NotFoundException("Login invalido");

            //if (usuario.OrganizationCollection is null)
            //    throw new NotFoundException("Não foi possível encontrar credencial de acesso do usuário informado para esta aplicacao");

            var token = await _tokenService.Gerar(usuario);

            if (token is null)
                throw new UnauthorizedException ("Não foi possivel gerar token acesso");

            return new AuthenticateUserResponse().Mapear(usuario, token);                         

        }
    }
}
