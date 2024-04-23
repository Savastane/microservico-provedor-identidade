using system.Security.API.Domain.Abstracts;
using system.Security.Entity.Collection;

namespace systemsecurity.domain
{
    public class Route : Entity
    {
        
        public Guid GuidApplication{ get; set; }
        public Guid GuidResource { get; set; }
        public string Title{ get; set; }
                
        public string Icon{ get; set; }
        public string Description { get; set; }
        public string Type { get; set; } /* InternalRouter ExternalRouter, Modal, SubMenu, Menu*/
        public string Action { get; set; }
        public string Order{ get; set; }
        public string CssClass { get; set; }
        public string Status { get; set; } // bloqueado / removido /ativo
        public int IsAccessOnlyRole { get; set; }

        public int Notification { get; set; }




    }
}
