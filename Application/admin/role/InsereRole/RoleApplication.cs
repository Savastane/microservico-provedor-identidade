namespace System.API.Application
{
    using FluentValidation;    
    using MediatR;    
    using Academico.Domain.Interface;    

    public class RoleApplication : IRequestHandler<RoleRequest, RoleResponse>
    {
        private readonly IApplicationRepository _repository;
        
        public RoleApplication(IApplicationRepository repository, IValidator<RoleRequest> validatorRequest)
        {
            _repository = repository;            
        }
        
        public async Task<RoleResponse> Handle(RoleRequest request, CancellationToken cancellationToken)
        {

            var roles = request.Mapear();

            var roleAdd  = await _repository.AddRole(roles);            
                       
            return new RoleResponse().Mapear(roleAdd);                         

        }
    }
}
