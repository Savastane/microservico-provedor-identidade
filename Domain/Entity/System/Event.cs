

using system.Security.API.Domain.Abstracts;
using system.Security.Entity.Collection;

namespace systemsecurity.domain
{
    
    public class Event : Entity
    {
        
        public Guid GuidUser { get; set; }
        public LocationDocument Location { get; set; }
        public DateTime DateEvent { get; set; }
        public string Command{ get; set; }
        public string Queue { get; set; }
        public string Topic { get; set; }
        public int  Status { get; set; } // 0 - add 1 - process 99 - erro
        public DateTime DateProcess { get; set; }
        public int ProcessCount { get; set; } // 0 - add 1 - process 99 - erro                
        public ErroCollection ErroCollection { get; set; } = new();        
        public string DataObject { get; set; }

    }
}
