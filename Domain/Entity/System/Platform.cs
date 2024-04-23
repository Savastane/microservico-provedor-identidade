
using system.Security.API.Domain.Abstracts;
using system.Security.Entity.Collection;

namespace systemsecurity.domain
{
    public class Platform : Entity
    {
          
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // bloqueado / removido /ativo

        public ApplicationCollection? ApplicationCollection { get; set; }


    }
}
