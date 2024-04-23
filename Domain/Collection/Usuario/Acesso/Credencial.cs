using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Security.API.Domain.Json.Usuario.Acesso
{
    public class Credencial
    {


        public Guid IdAplicacao { get; set; }
        public Guid IdOrganizacao { get; set; }
        public string Organizacao { get; set; }
        public List<RolesOrganizacao> Roles { get; set; }
        public Credencial()
        {
        }

        public Credencial(Guid IdAplicacao, Guid IdOrganizacao, string Organizacao, List<string> roles)
        {
            this.IdAplicacao = IdAplicacao;
            this.IdOrganizacao = IdOrganizacao;
            this.Organizacao = Organizacao;
            AddRoles(roles);
        }


        public void AddRoles(List<string> roles, bool delete = false)
        {

            if (delete)
            {
                Roles = null;
            }

            if (Roles is null)
                Roles = new();



            foreach (var role in roles)
                Roles.Add(new RolesOrganizacao(role));


        }

    }
}
