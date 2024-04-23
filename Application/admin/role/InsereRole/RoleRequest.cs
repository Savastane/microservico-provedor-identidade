namespace System.API.Application
{
    using Academico.Domain;
    using systemsecurity.domain;
    using MediatR;
    using MediatR.NotificationPublishers;
    using system.Security.API.Domain.Json.Role.Rotas;

    /// <summary>
    /// Request Login
    /// </summary>
    public class RoleRequest : IRequest<RoleResponse>
    {        
        public AmbienteModel? Ambiente { get; set; }        
        public string? Role { get; set; }
        public string? Nivel { get; set; }
        //public RotasRequest RotasRequest  { get; set; }

        public MenuRequest Menu { get; set; }


        public Role Mapear()
        {
            var roles = new Role()
            {
                Name = this.Role,
                GuidApplication = this.Ambiente.IdAplicacao.Value,
//                IsBlock = 0,
  //              IsDelete = 0,
                Description = this.Role,                
                //Level = this.Nivel,
                //Rotas = new()
                //{
                //    SubRotas = new()
                //}
            };


        //    roles.Rotas.SubRotas = CriarSubRotas(Menu.Rotas);

            
            return roles;
        }

        private List<SubRotasRota> CriarSubRotas(List<RotasRequest> request)
        {
            List<SubRotasRota> subRotas = new();

            foreach (var item in request)
            {
                SubRotasRota sub = new()
                {
                    Descricao = item.Descricao,
                    Tipo = item.Tipo,
                    Icon = item.Icone,
                    Rota = item.Rota,
                    Action = item.Rota
                };
                

                if (item.SubRotas?.Count > 0)
                {
                    sub.SubRotas = CriarSubRotas(item.SubRotas) ;
                }
                subRotas.Add(sub);
            };

            return subRotas;
        }


    }

  

    public class MenuRequest
    {
        
        public List<RotasRequest> Rotas { get; set; }
    }
        
    public class RotasRequest
    {         
        public string Id1 { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set;}
        public string Icone { get; set; }        
        public string Rota { get; set; }
        public List<RotasRequest> SubRotas { get; set; }
    }

    
}
