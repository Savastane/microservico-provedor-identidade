using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Security.API.Domain.Json.Usuario.Acesso
{
    public class RolesOrganizacao
    {

        public string Role { get; set; }

        public RolesOrganizacao()
        {
        }
        public RolesOrganizacao(string Role)
        {
            this.Role = Role;
        }

    }
}
