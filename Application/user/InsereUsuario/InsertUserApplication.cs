namespace System.API.Application
{
    using FluentValidation;
    
    using MediatR;
    
    using Academico.Domain.Interface;
    
    
    using systemsecurity.domain;
    using system.Security.Entity.Collection;
    using system.Security.API.Domain.Abstracts;
    using system.Security.API.Repository;

    public class InsertUserApplication : IRequestHandler<InsertUserRequest, InsertUserResponse>
    {
        private readonly IUnitOfWork _UnitOfWork;               
        
        public InsertUserApplication(IUnitOfWork UnitOfWork, IValidator<InsertUserRequest> validatorRequest)
        {
            _UnitOfWork = UnitOfWork;            
        }
        
        public async Task<InsertUserResponse> Handle(InsertUserRequest request, CancellationToken cancellationToken)
        {
            var usuario = request.Mapear();
                        
            var usuarioFind = await _UnitOfWork.GetUserRepository().GetByEmail(usuario.Email);


            if (usuarioFind == null)
            {
                await _UnitOfWork.GetUserRepository().InsertAsync(usuario);                
            }
            else
            {
                usuario = usuarioFind;

                if (usuario.OrganizationCollection is not null)                
                {
                    //aplicacao
                    //var credenciais = usuario.OrganizationCollection.Organizations.Where(c => c.Applications.IdAplicacao == request.IdAplicacao && c.IdOrganizacao == request.IdOrganizacao ).FirstOrDefault();
                   // var organizacao = usuario.OrganizationCollection.Organizations.Where(c => c.Guid == request.IdOrganizacao).FirstOrDefault();


                    /* sava
                    if (organizacao is null)
                        //usuario.OrganizationCollection.Organizations.Add(new OrganizationDocument(request.IdAplicacao.Value, request.IdOrganizacao.Value, request.Organizacao, request.Roles));                    
                        usuario.OrganizationCollection.Organizations.Add(new OrganizationDocument());
                    else
                        organizacao.AddRoles(request.Roles, true);
                    */

                }
                await _UnitOfWork.GetUserRepository().UpdateAsync(usuario);
            }
            try
            {
                await _UnitOfWork.CommitAsync();
            }
            catch (Exception e)
            {

                throw;
            }
            


            return new InsertUserResponse().Mapear(usuario);                         

        }
    }
}
