

using system.Security.API.Domain.Abstracts;

namespace systemsecurity.domain
{
    
    public class Routing : Entity
    {        
        public Guid GuidApplication { get; set; }
        public string Name{ get; set; }        
        public string Description { get; set; }
        public system.Security.Entity.Collection.RouteCollection? RouterCollection { get; set; }


    }
}
