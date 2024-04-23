using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Security.API.Domain.Json.Role.Rotas
{
    public class SubRotasRota
    {
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Icon { get; set; }
        public string Action { get; set; }
        public string Rota { get; set; }
        public List<SubRotasRota> SubRotas { get; set; }

    }
}
