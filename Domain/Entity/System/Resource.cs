using system.Security.API.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemsecurity.domain
{
    public class Resource : Entity
    {
           

        public Guid GuidApplication { get; set; }
        public int Order { get; set; }        
        public string Type { get; set; } //action
        public string Group { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconeOffUrl{ get; set; }
        public string IconeOnUrl { get; set; }
        public string ActionUrl { get; set; }                             
        
        public int? Notification{ get; set; }
        

    }

    
}


