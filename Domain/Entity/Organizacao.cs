using system.Security.Entity.Collection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemsecurity.domain
{
    public class Organizacao
    {
        public long Id { get; set; }
        public Guid GuidOrganizacao { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial{ get; set; }
        public string Documento { get; set; }
        public string AmbienteCollection { get; set; }
     //   public ApplicationCollection? ApplicationCollection { get; set; }
        public int Bloqueado{ get; set; }
        public int Exclusao{ get; set; }

    }
}
