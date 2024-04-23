


namespace System.API.Application
{
    using MediatR;
    using Academico.Domain;
    using systemsecurity.domain;

    public class RoleResponse : IRequest<RoleResponse>
    {

        public Guid Id { get; set; }
      

      
        public RoleResponse Mapear(Role role)
        {
            Id      = role.Id;
            return this;
        }


        public RoleResponse()
        {
            
        }

        
        


    }


}
