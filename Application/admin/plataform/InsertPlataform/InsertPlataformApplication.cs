namespace System.API.Application
{
    using FluentValidation;
    
    using MediatR;
    
    using Academico.Domain.Interface;
       
    
    using system.Security.Entity.Collection;
    using global::Application.General.Exceptions;

    public class InsertPlataformApplication : IRequestHandler<InsertPlataformRequest, InsertPlataformResponse>
    {
        private readonly IPlatformRepository _repository;
        
        public InsertPlataformApplication(IPlatformRepository repository, IValidator<InsertPlataformRequest> validatorRequest)
        {
            _repository = repository;            
        }
        
        public async Task<InsertPlataformResponse> Handle(InsertPlataformRequest request, CancellationToken cancellationToken)
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

//plataform = await _repository.Insert(plataform);
            
            }
                       
            return new InsertPlataformResponse().Mapear(plataform);                         

        }
    }
}
