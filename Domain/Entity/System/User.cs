

using Consul;
using system.Security.API.Domain.Abstracts;
using system.Security.Entity.Collection;

namespace systemsecurity.domain
{
    public class User : Entity
    {        
        public Guid GuidPlataform { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Document { get; set; }
        public string Status { get; set; } // bloqueado / removido /ativo
        public ResourceCollection? Allow { get; set; } = new();        
        public ResourceCollection? Deny { get; set; } = new();        
        public OrganizationCollection? OrganizationCollection { get; set; }
        public User MapAutenticacao(string email, string password)
        {
            this.Email = email;
            this.Password = password;

            return this;
        }
    }


    
}
