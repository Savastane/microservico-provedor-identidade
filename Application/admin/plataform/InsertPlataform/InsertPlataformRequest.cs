namespace System.API.Application
{
    using Academico.Domain;
    using systemsecurity.domain;
    
    
    using MediatR;
    using MediatR.NotificationPublishers;

    /// <summary>
    /// Request Login
    /// </summary>
    public class InsertPlataformRequest : IRequest<InsertPlataformResponse>
    {

        
        // public AmbienteModel? Ambiente { get; set; }
        public Guid? IdUsuario { get; set; }
        public Guid? IdAplicacao { get; set; }
        public Guid? IdOrganizacao { get; set; }
        public string? Organizacao { get; set; }



        public string? Nome { get; set; }        
        public string Email { get; set; }        
        public string? Documento { get; set; }     
        public List<string>? Roles { get; set; }
        
                
        

        public Platform Mapear()
        {

            var plataforma = new Platform()
            {               
                
            };         

        //    usuario.Acesso.Credenciais.Add(new Credencial(Ambiente.IdAplicacao.Value, Ambiente.IdOrganizacao.Value, Ambiente.Organizacao, Roles));
            
            return plataforma;
        }
    }

    
    public class InsertCredencialResponseRequest1
    {
        public List<InsertAcessoRoles>? AcessoOrganizacao { get; set; }
    }

    public class InsertAcessoRoles1 
    {        
        public List<string>? Roles { get; set; }

    }
}
