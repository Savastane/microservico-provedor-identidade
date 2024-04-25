namespace System.API.Application
{
    using FluentValidation;
    
    using MediatR;
    
    using Academico.Domain.Interface;
       
    
    using system.Security.Entity.Collection;
    using global::Application.General.Exceptions;

    public class InsertPlatformApplication : IRequestHandler<InsertPlatformRequest, InsertPlatformResponse>
    {
        private readonly IPlatformRepository _repository;
        
        public InsertPlatformApplication(IPlatformRepository repository, IValidator<InsertPlatformRequest> validatorRequest)
        {
            _repository = repository;            
        }
        
        public async Task<InsertPlatformResponse> Handle(InsertPlatformRequest request, CancellationToken cancellationToken)
        {
            var plataform = request.Mapear();

            var plataformFind = await _repository.GetByName(plataform.Name);


            if (plataformFind is not null)
            {
                throw new ConflitException($"Nome de plataforma já cadastrado no banco de dados [{plataform.Name}]");                
            }
            else
            {

                plataform.ApplicationCollection = new ApplicationCollection()
                {
                    Applications = new List<ApplicationDocument>()
                };
                //plataform =
                await _repository.InsertAsync(plataform);
            
            }
                       
            return new InsertPlatformResponse().Mapear(plataform);                         

        }
    }
}
