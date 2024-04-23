namespace System.API.Application
{
    using Academico.Domain;
    using systemsecurity.domain;
    
    
    using MediatR;
    using MediatR.NotificationPublishers;

    /// <summary>
    /// Request Login
    /// </summary>
    public class InsertUserRequest : IRequest<InsertUserResponse>
    {
        public Guid? Id { get; set; }
        // public AmbienteModel? Ambiente { get; set; }
        public Guid? IdUsuario { get; set; }
        public Guid? GuidPlataform { get; set; }
        
        public string? Organizacao { get; set; }
        public string? Nome { get; set; }        
        public string Email { get; set; }        
        public string? Documento { get; set; }     
        public List<string>? Roles { get; set; }      

        public  User Mapear()
        {
            var usuario = new User()
            {
                
                Name = Nome,
                GuidPlataform = GuidPlataform.Value,                
                Email = this.Email,
                Photo = "/",
                Password = "1234567",
                Document = Documento,
                Status ="Ativo",                
                OrganizationCollection = new() {
                    Organizations = new()
                }                
            };         
        //    usuario.Acesso.Credenciais.Add(new Credencial(Ambiente.IdAplicacao.Value, Ambiente.IdOrganizacao.Value, Ambiente.Organizacao, Roles));            
            return usuario;
        }
    }

    
    public class InsertCredencialResponseRequest
    {
        public List<InsertAcessoRoles>? AcessoOrganizacao { get; set; }
    }

    public class InsertAcessoRoles  
    {        
        public List<string>? Roles { get; set; }

    }
}
