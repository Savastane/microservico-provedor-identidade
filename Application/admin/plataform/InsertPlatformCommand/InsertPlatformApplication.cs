namespace System.API.Application
{
    using FluentValidation;
    
    using MediatR;
    
    using Academico.Domain.Interface;
       
    
    using system.Security.Entity.Collection;
    using global::Application.General.Exceptions;
    using system.Security.API.Domain.Abstracts;
    using systemsecurity.domain;

    public class InsertPlatformApplication : IRequestHandler<InsertPlatformRequest, InsertPlatformResponse>
    {
        private readonly IUnitOfWork _UnitOfWork;
                
        
        public InsertPlatformApplication(IUnitOfWork UnitOfWork, IValidator<InsertPlatformRequest> validatorRequest)
        {
            _UnitOfWork = UnitOfWork;
        }
        
        public async Task<InsertPlatformResponse> Handle(InsertPlatformRequest request, CancellationToken cancellationToken)
        {
            var plataform = request.Mapear();

            var plataformFind = await _UnitOfWork.GetPlatformRepository().GetByName(plataform.Name);


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
                               
                await _UnitOfWork.GetPlatformRepository().InsertAsync(plataform);
            
            }


            try
            {
                await _UnitOfWork.CommitAsync();
            }
            catch (Exception e)
            {

                throw;
            }


            return new InsertPlatformResponse().Mapear(plataform);                         

        }
    }
}
