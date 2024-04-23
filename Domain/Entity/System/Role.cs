using system.Security.API.Domain.Abstracts;
using system.Security.Entity.Collection;



namespace systemsecurity.domain
{
    public class Role : Entity
    {   
        public Guid GuidApplication { get; set; }
        public string Name{ get; set; }
        public string Scope { get; set; }
        public string Description { get; set; }            
        public system.Security.Entity.Collection.RouteCollection? RouteCollection { get; set; }

    }
}
